using Draw.src.Model;
using System;
using System.Collections.Generic;
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
        private Shape selection;
        public Shape Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        private Polygon polySelection;
        public Polygon PolySelection
        {
            get { return polySelection; }
            set { polySelection = value; }
        }

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
            if (Selection != null)
            {
                Selection.RotationMatrix = new Matrix();
                Selection.RotationAngle = rotationAngle;
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

        public void AddPolygon(PointF location)
        {
            float minX = pointsList.Min(p => p.X);
            float maxX = pointsList.Max(p => p.X);

            float minY = pointsList.Min(p => p.Y);
            float maxY = pointsList.Max(p => p.Y);

            float width = maxX - minX;
            float height = maxY - minY;

            PolygonShape polygon = new PolygonShape(new Rectangle(
                    (int)location.X,
                    (int)location.Y,
                    (int)width,
                    (int)height),
                    pointsList);

            polygon.FillColor = Color.White;
            polygon.StrokeColor = Color.Black;

            PolygonList.Add(polygon);
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

        public Polygon ContainsPointPolygon(PointF point)
        {
            for (int i = PolygonList.Count - 1; i >= 0; i--)
            {
                if (PolygonList[i].Contains(point))
                {
                    return PolygonList[i];
                }
            }
            return null;
        }

        public void TranslateTo(PointF p)
        {
            if (selection != null)
            {
                selection.Location = new PointF(selection.Location.X + p.X - lastLocation.X, selection.Location.Y + p.Y - lastLocation.Y);
                lastLocation = p;
            }
            else if (polySelection != null)
            {
                polySelection.Location = new PointF(polySelection.Location.X + p.X - lastLocation.X, polySelection.Location.Y + p.Y - lastLocation.Y);
                lastLocation = p;
            }
        }

        public override void Draw(Graphics grfx)
        {
            base.Draw(grfx);

            if (Selection != null)
            {
                grfx.DrawRectangle(
                    new Pen(Color.LightBlue, 2),
                    Selection.Location.X - 5,
                    Selection.Location.Y - 5,
                    Selection.Width + 7,
                    Selection.Height + 7
                    );
            }
        }
    }
}
