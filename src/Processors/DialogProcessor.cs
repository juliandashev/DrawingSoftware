using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

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

        private SubShapes SubShapes { get; set; }

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

        private List<PointF> pointsList = new List<PointF>();
        public List<PointF> PointsList
        {
            get { return pointsList; }
            set { pointsList = value; }
        }

        #endregion

        public void RotateShape(float rotationAngle)
        {
            if (Selection.Count >= 1)
            {
                Selection[0].RotationMatrix = new Matrix();
                Selection[0].RotationAngle = rotationAngle;
            }
        }

        public void RotateGroup(float rotationAngle)
        {
            SubShapes.RotationAngle = rotationAngle;

            foreach(var item in SubShapes.GroupShapes)
            {
                // TODO: !!
                item.RotationMatrix.Rotate(rotationAngle);
            }
        }

        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;
            rect.StrokeColor = Color.Black;

            ShapeList.Add(rect);
        }

        public void AddRandomSquare()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 100));
            rect.FillColor = Color.White;
            rect.StrokeColor = Color.Black;

            ShapeList.Add(rect);
        }

        public void AddPoint()
        {
            PointShape point = new PointShape(new Rectangle(
                (int)ClickedPoint.X,
                (int)ClickedPoint.Y,
                    10, 10));

            point.FillColor = Color.Red;
            point.StrokeColor = Color.Black;

            pointsList.Add(ClickedPoint);
            ShapeList.Add(point);
        }

        public void AddPolygon()
        {
            float minX = pointsList.Min(p => p.X);
            float maxX = pointsList.Max(p => p.X);

            float minY = pointsList.Min(p => p.Y);
            float maxY = pointsList.Max(p => p.Y);

            float width = maxX - minX;
            float height = maxY - minY;

            PointF center = new PointF((maxX + minX) / 2, (maxY + minY) / 2);

            PolygonShape polygon = new PolygonShape(new Rectangle(
                    (int)center.X,
                    (int)center.Y,
                    (int)width,
                    (int)height),
                    pointsList)
            {
                FillColor = Color.White,
                StrokeColor = Color.Black
            };

            ShapeList.Add(polygon);
        }

        public void GroupElements()
        {
            List<Shape> temp = ShapeList;

            if (ShapeList.Count >= 1)
            {
                float minX = temp.Min(x => x.Rectangle.Left);
                float minY = temp.Min(y => y.Rectangle.Top);

                float maxX = temp.Max(x => x.Rectangle.Right);
                float maxY = temp.Max(y => y.Rectangle.Bottom);

                SubShapes = new SubShapes(new RectangleF(minX, minY, maxX - minX, maxY - minY));

                SubShapes.GroupShapes = Selection;

                Selection = new List<Shape>();

                ShapeList.Add(SubShapes);

                foreach (var item in SubShapes.GroupShapes)
                {
                    ShapeList.Remove(item);
                }
            }
        }

        // Curently in maintanance :D

        //public void AddRandomTriangle()
        //{
        //    List<PointF> points = new List<PointF>();

        //    Random rnd = new Random();

        //    int x = rnd.Next(100, 1000);
        //    int y = rnd.Next(100, 600);

        //    points.Add(new PointF(x, y));

        //    points.Add(new PointF(x + 50, y - 50));

        //    points.Add(new PointF(
        //        x + rnd.Next(0, 50),
        //        y + rnd.Next(50, 100)));

        //    TriangleShape triag = new TriangleShape(points);
        //    triag.FillColor = Color.White;
        //    triag.StrokeColor = Color.Black;

        //    PolygonList.Add(triag);
        //}

        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 200, 100));
            ellipse.FillColor = Color.White;
            ellipse.StrokeColor = Color.Black;

            ShapeList.Add(ellipse);
        }

        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 100));
            ellipse.FillColor = Color.White;
            ellipse.StrokeColor = Color.Black;

            ShapeList.Add(ellipse);
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
                foreach (var item in selection)
                {
                    item.Location = new PointF(
                        item.Location.X + p.X - lastLocation.X,
                        item.Location.Y + p.Y - lastLocation.Y
                        );
                }
                lastLocation = p;
            }
        }

        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);

            if (Selection.Count >= 1)
            {
                foreach (Shape item in Selection)
                {
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
