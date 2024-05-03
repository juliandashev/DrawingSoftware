using Draw.src.Model;
using Draw.src.Processors;
using Draw.src.Processors.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace Draw
{
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties
        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        // private SubShapes Groups = new SubShapes();
        private List<SubShapes> GroupList = new List<SubShapes>();

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "рисуване" на избрания елемент.
        /// </summary>
        private bool isDrawing;
        public bool IsDrawing
        {
            get { return isDrawing; }
            set { isDrawing = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
        public PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        private PointF clickedPoint;
        public PointF ClickedPoint
        {
            get { return clickedPoint; }
            set { clickedPoint = value; }
        }

        public static List<PointShape> PointsList { get; set; } = new List<PointShape>();

        public void SetStrokeColor(Color c)
        {
            if (Selection.Count >= 1)
            {
                foreach (Shape shape in Selection)
                    shape.StrokeColor = c;
            }
        }

        public void SetFillColor(Color c)
        {
            if (Selection.Count >= 1)
            {
                foreach (Shape shape in Selection)
                    shape.FillColor = c;
            }
        }

        public void SetOpacity(int o)
        {
            if (0 <= o && o <= 255)
            {
                if (Selection.Count >= 1)
                    foreach (Shape shape in Selection)
                        shape.Opacity = o;
            }
            else
                return;
        }

        public void SetStrokeWidth(float width)
        {
            if (0 <= width && width <= 50)
            {
                if (Selection.Count >= 1)
                    foreach (Shape shape in Selection)
                        shape.StrokeWidth = width;
            }
            else
                return;
        }

        #endregion

        // --------------------------------------------------------------------------------------------------------------
        #region Add Shapes Methods
        // --------------------------------------------------------------------------------------------------------------
        public void AddRandomRectangle(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;
            rect.StrokeColor = Color.Black;
            rect.StrokeWidth = strokeWidth;

            ShapeList.Add(rect);
        }

        public void AddRandomSquare(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100));
            rect.FillColor = Color.White;
            rect.StrokeColor = Color.Black;
            rect.StrokeWidth = strokeWidth;

            ShapeList.Add(rect);
        }

        public void AddRandomTriangle(int strokeWidth)
        {
            Random rnd = new Random();

            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            int width = 200;
            int height = 100;

            List<PointShape> points = new List<PointShape>()
            {
                new PointShape(new RectangleF(x + width, y, 3, 3)), // top right corner
                new PointShape(new RectangleF(x, y + height, 3, 3)), // bottom left corner
                new PointShape(new RectangleF(x + width, y + height, 3, 3)) // bottom right
            };

            PolygonShape triangle = new PolygonShape(new RectangleF(
                    x,
                    y,
                    width,
                    height),
                    points)
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth
            };

            ShapeList.Add(triangle);
        }

        public void AddPoint()
        {
            PointShape point = new PointShape(new RectangleF(
                    ClickedPoint.X - 3, ClickedPoint.Y - 3, 8, 10))
            {
                FillColor = Color.Purple,
                StrokeColor = Color.Black
            };

            PointsList.Add(point);
            ShapeList.Add(point);
        }

        private static List<PointShape> polygonPointsList = new List<PointShape>();
        public void AddPolygon(int strokeWidth = 1)
        {
            if (PointsList.Count >= 1)
            {
                polygonPointsList = new List<PointShape>(PointsList);
            }

            float minX = polygonPointsList.Min(p => p.Location.X);
            float maxX = polygonPointsList.Max(p => p.Location.X);

            float minY = polygonPointsList.Min(p => p.Location.Y);
            float maxY = polygonPointsList.Max(p => p.Location.Y);

            PolygonShape polygon = new PolygonShape(new RectangleF(
                    minX,
                    minY,
                    maxX - minX,
                    maxY - minY),
                    polygonPointsList)
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth
            };

            ShapeList.Insert(ShapeList.IndexOf(PointsList[0]), polygon);
            PointsList.Clear();
        }

        private static List<PointShape> controlPoints = new List<PointShape>();
        public void AddBezier(int strokeWidth = 2)
        {
            if (PointsList.Count >= 1)
            {
                controlPoints = new List<PointShape>(PointsList);
            }

            float minX = controlPoints.Min(p => p.Location.X);
            float maxX = controlPoints.Max(p => p.Location.X);

            float minY = controlPoints.Min(p => p.Location.Y);
            float maxY = controlPoints.Max(p => p.Location.Y);

            BezierCurveShape bezier = new BezierCurveShape(new RectangleF(
                minX,
                minY,
                maxX - minX,
                maxY - minY),
                controlPoints)
            {
                StrokeColor = Color.Coral,
                StrokeWidth = strokeWidth
            };

            ShapeList.Insert(ShapeList.IndexOf(PointsList[0]), bezier);
            PointsList.Clear();
        }

        public void AddBSpline(int strokeWidth = 2)
        {
            if (PointsList.Count >= 1)
            {
                controlPoints = new List<PointShape>(PointsList);
            }

            float minX = controlPoints.Min(p => p.Location.X);
            float maxX = controlPoints.Max(p => p.Location.X);

            float minY = controlPoints.Min(p => p.Location.Y);
            float maxY = controlPoints.Max(p => p.Location.Y);

            BSplineShape splineShape = new BSplineShape(new RectangleF(
                minX,
                minY,
                maxX - minX,
                maxY - minY),
                controlPoints)
            {
                StrokeColor = Color.Red,
                StrokeWidth = strokeWidth,
            };

            ShapeList.Insert(ShapeList.IndexOf(PointsList[0]), splineShape);
            PointsList.Clear();
        }

        public void AddRandomStar(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            StarShape star = new StarShape(new Rectangle
                (x, y,
                200,
                200))
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth
            };

            ShapeList.Add(star);
        }

        public void AddRandomRhomb(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RhombShape rhomb = new RhombShape(new RectangleF
                (x, y,
                200,
                200))
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth
            };

            ShapeList.Add(rhomb);
        }

        public void AddRandomEllipse(int strokeWidth = 1)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 200, 100));
            ellipse.FillColor = Color.White;
            ellipse.StrokeColor = Color.Black;
            ellipse.StrokeWidth = strokeWidth;

            ShapeList.Add(ellipse);
        }

        public void AddRandomCircle(int strokeWidth = 1)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 100));
            ellipse.FillColor = Color.White;
            ellipse.StrokeColor = Color.Black;
            ellipse.StrokeWidth = strokeWidth;

            ShapeList.Add(ellipse);
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region Group Action Methods
        // --------------------------------------------------------------------------------------------------------------
        private void ScaleGroup(float scaleCoef)
        {
            List<SubShapes> selectedGroup = GroupList.Intersect(Selection).OfType<SubShapes>().ToList();

            if (selectedGroup.Count >= 1)
            {
                float coef = scaleCoef;

                foreach (var group in selectedGroup)
                {
                    PointF center = new PointF((group.Rectangle.Width / 2) + group.Rectangle.X, (group.Rectangle.Height / 2) + group.Rectangle.Y);

                    foreach (var shape in group.SubShapesList)
                    {
                        Matrix scaleMatrix = new Matrix(coef, 0, 0, coef, center.X * (1 - coef), center.Y * (1 - coef)); // увеличаване или намаляне около центъра
                        // Мащабиране по S1S2 е същото като мащабиране по S2S1, което означава, че са комутативни
                        shape.TransformationMatrix.Multiply(scaleMatrix);
                    }

                    group.TransformationMatrix.Scale(scaleCoef, scaleCoef);
                }
            }
        }

        private void RotateGroup(float rotationAngle)
        {
            List<SubShapes> selectedGroup = GroupList.Intersect(Selection).OfType<SubShapes>().ToList();

            if (selectedGroup.Count >= 1)
            {
                #region Other formula for finding the center
                // the formula for the center is defined as


                // (p1 + q1) / 2 thats the x coordinate
                // and
                // (p2 + q2) / 2 thats the y coordinate
                // of the center

                // It is outside the foreach because we want to calculate it once not for each shape that is in the group

                // --------------------------------------------------------------------------------------------------------------
                /*
                    Формулата за центъра е:

                    (p1 + q1) / 2 това е х координатата |
                                                        | на цантъра
                    (p2 + q2) / 2 това е у координатата |

                */

                // --------------------------------------------------------------------------------------------------------------

                //PointF topLeft = new PointF(SubShapes.Rectangle.Left, SubShapes.Rectangle.Top); // imagine it as point A (p1, p2)
                //PointF bottomRight = new PointF(SubShapes.Rectangle.Right, SubShapes.Rectangle.Bottom); // and this as point B (q1, q2)

                //PointF center = new PointF(
                //         (topLeft.X + bottomRight.X) / 2,
                //         (topLeft.Y + bottomRight.Y) / 2
                //    );

                #endregion

                // Second way of finding the center

                foreach (var group in selectedGroup)
                {
                    PointF center = new PointF((group.Rectangle.Width / 2) + group.Rectangle.X, (group.Rectangle.Height / 2) + group.Rectangle.Y);

                    foreach (var shape in group.SubShapesList)
                    {
                        shape.TransformationMatrix.RotateAt(rotationAngle, center);
                    }

                    group.TransformationMatrix.RotateAt(rotationAngle, center);
                }
            }
        }

        public void GroupElements()
        {
            List<Shape> temp = Selection;

            if (ShapeList.Count >= 1)
            {
                float minX = temp.Min(x => x.Rectangle.Left);
                float minY = temp.Min(y => y.Rectangle.Top);

                float maxX = temp.Max(x => x.Rectangle.Right);
                float maxY = temp.Max(y => y.Rectangle.Bottom);

                SubShapes Groups = new SubShapes(new RectangleF(minX, minY, maxX - minX, maxY - minY))
                {
                    SubShapesList = Selection
                };

                Selection = new List<Shape>();

                ShapeList.Add(Groups);
                GroupList.Add(Groups);

                foreach (var item in Groups.SubShapesList)
                {
                    ShapeList.Remove(item);
                }
            }
        }

        // TODO: Ungroup shapes
        public void UnGroupElements()
        {
            var intersection = GroupList.Intersect(Selection).OfType<SubShapes>().ToList();

            if (intersection.Count >= 1)
            {
                foreach (var group in intersection)
                {
                    ShapeList.AddRange(group.SubShapesList);
                    group.SubShapesList.Clear();
                }
                Selection.Clear();
            }
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region Shape Action Methods
        // --------------------------------------------------------------------------------------------------------------
        private void RotateShape(float rotationAngle)
        {
            var shapeType = Selection.Except(GroupList).ToList();

            if (shapeType.Count >= 1)
            {
                foreach (Shape shape in shapeType)
                {
                    PointF center = new PointF((shape.Rectangle.Width / 2) + shape.Rectangle.X, (shape.Rectangle.Height / 2) + shape.Rectangle.Y);

                    shape.TransformationMatrix.RotateAt(rotationAngle, center);
                }
            }
        }

        private void ScaleShape(float scaleCoef)
        {
            var shapeType = Selection.Except(GroupList).ToList();

            if (shapeType.Count >= 1)
            {
                foreach (Shape shape in shapeType)
                {
                    PointF center = new PointF((shape.Rectangle.Width / 2) + shape.Rectangle.X, (shape.Rectangle.Height / 2) + shape.Rectangle.Y);

                    Matrix scaleMatrix = new Matrix(scaleCoef, 0, 0, scaleCoef, center.X * (1 - scaleCoef), center.Y * (1 - scaleCoef)); // увеличаване или намаляне около центъра
                    shape.TransformationMatrix.Multiply(scaleMatrix);
                }
            }
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        public void Rotate(float angle)
        {
            RotateShape(angle);
            RotateGroup(angle);
        }
        
        public void Scale(float scaleCoef)
        {
            ScaleShape(scaleCoef);
            ScaleGroup(scaleCoef);
        }

        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {
                    return ShapeList[i];
                }
            }
            return null;
        }

        public void TranslateTo(PointF p)
        {
            if (selection.Count >= 1)
            {
                PointF[] transformPointsArray = new PointF[] { p };

                foreach (var item in selection)
                {
                    Matrix temp = item.TransformationMatrix.Clone();

                    temp.Invert();

                    temp.TransformPoints(transformPointsArray);

                    item.Location = new PointF(
                        item.Location.X + transformPointsArray[0].X - lastLocation.X,
                        item.Location.Y + transformPointsArray[0].Y - lastLocation.Y
                        );
                }
                lastLocation = transformPointsArray[0];
            }
        }

        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);

            if (Selection.Count >= 1)
            {
                foreach (Shape item in Selection)
                {
                    grfx.Transform = item.TransformationMatrix;

                    grfx.DrawRectangle(
                        new Pen(Color.LightBlue, 2),
                        item.Location.X - 5,
                        item.Location.Y - 5,
                        item.Width + 7,
                        item.Height + 7
                        );
                }
            }
        }
    }
}
