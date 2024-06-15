using Draw.src.Model;
using Draw.src.Model.Shapes;
using Draw.src.Processors;
using Draw.src.Processors.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

        public Stack<Shape> Clipboard { get; set; } = new Stack<Shape>();

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

        public void SetName(string name)
        {
            if (Selection.Count >= 1)
            {
                int index = 1;
                foreach (var item in Selection)
                {
                    item.Name = name + index;
                    index++;
                }
            }
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

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200))
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth,
                Name = "Rectangle",
            };

            ShapeList.Add(rect);
        }
        public void AddExamShape(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            ExamShape3 exam = new ExamShape3(new Rectangle(x, y, 100, 100))
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth,
                Name = "ExamShape",
            };

            ShapeList.Add(exam);
        }

        public void AddRandomSquare(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100))
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth,
                Name = "Square",
            };

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
                StrokeWidth = strokeWidth,
                Name = "Triangle"
            };

            ShapeList.Add(triangle);
        }

        public void AddPoint()
        {
            PointShape point = new PointShape(new RectangleF(
                    ClickedPoint.X - 3, ClickedPoint.Y - 3, 8, 10))
            {
                FillColor = Color.Purple,
                StrokeColor = Color.Black,
                Name = "Point"
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
                StrokeWidth = strokeWidth,
                Name = "Polygon"
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
                StrokeWidth = strokeWidth,
                Name = "Bezier Curve"
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
                Name = "B-Spline Curve"
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
                StrokeWidth = strokeWidth,
                Name = "Star"
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
                StrokeWidth = strokeWidth,
                Name = "Rhomb"
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
            ellipse.Name = "Ellipse";

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
            ellipse.Name = "Circle";

            ShapeList.Add(ellipse);
        }

        public void AddRandomNTagon(int sidesNumber, int strokeWidth = 1)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            NTagonShape nTagon = new NTagonShape(new Rectangle
                (x, y,
                200,
                200), sidesNumber)
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth,
                Name = sidesNumber + "-tagon"
            };

            ShapeList.Add(nTagon);
        }

        public void AddRandomHeart(int strokeWidth)
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            HeartShape heart = new HeartShape(new Rectangle(x, y, 100, 100))
            {
                FillColor = Color.White,
                StrokeColor = Color.Black,
                StrokeWidth = strokeWidth,
                Name = "Heart",
            };

            ShapeList.Add(heart);
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
                foreach (var group in selectedGroup)
                {
                    PointF center = new PointF((group.Rectangle.Width / 2) + group.Rectangle.X, (group.Rectangle.Height / 2) + group.Rectangle.Y);
                    Matrix scaleMatrix = new Matrix(scaleCoef, 0, 0, scaleCoef, center.X * (1 - scaleCoef), center.Y * (1 - scaleCoef)); // увеличаване или намаляне около центъра

                    foreach (var shape in group.SubShapesList)
                    {
                        // Мащабиране по S1S2 е същото като мащабиране по S2S1, което означава, че са комутативни
                        shape.TransformationMatrix.Multiply(scaleMatrix);
                    }

                    group.TransformationMatrix.Multiply(scaleMatrix);
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
                    SubShapesList = Selection,
                    Name = "Group of " + temp.Count
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
                    group.Name = "";
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

        // --------------------------------------------------------------------------------------------------------------
        #region Serialization and Deserialization
        // --------------------------------------------------------------------------------------------------------------

        public void SerializeModel(string filePath)
        {
            FileStream fileStream;
            BinaryFormatter formatter = new BinaryFormatter();

            fileStream = File.Create(filePath);
            formatter.Serialize(fileStream, ShapeList);

            fileStream.Close();
        }

        public void DeserializeModel(string filePath)
        {
            FileStream stream;
            BinaryFormatter formatter = new BinaryFormatter();

            object temp = null;
            if (File.Exists(filePath))
            {
                stream = File.OpenRead(filePath);
                temp = formatter.Deserialize(stream);

                var res = (List<Shape>)temp;
                res.ForEach(s => ShapeList.Add(s));
                stream.Close();
            }
        }

        public void SaveToJsonFile(string filePath)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.Auto,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            settings.Converters.Add(new MatrixConverter());
            settings.Converters.Add(new BaseConverter());

            string jsonString = JsonConvert.SerializeObject(ShapeList, settings);
            File.WriteAllText(filePath, jsonString);
        }

        public List<Shape> LoadFromJsonFile(string filePath)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new MatrixConverter());

            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Shape>>(jsonString, settings);
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

        public void Copy()
        {
            while(Clipboard.Count > 0)
                Clipboard.Pop();

            if (Selection.Count >= 1)
                foreach (var item in Selection)
                    Clipboard.Push(item);
        }

        public void Paste()
        {
            Random random = new Random();

            foreach (var item in Clipboard)
            {
                int x = random.Next(100, 1000);
                int y = random.Next(100, 600);

                var shape = item.Clone();
                shape.Location = new Point(x, y);
                shape.Name = item.Name + "Copy";

                ShapeList.Add(shape);
            }
        }

        public void SelectEverything()
        {
            foreach (var item in ShapeList)
            {
                Selection.Add(item);
            }
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
