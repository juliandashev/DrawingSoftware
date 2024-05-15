using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    [Serializable]
    public abstract class Spline : Polygon
    {
        #region Constructors

        public Spline(RectangleF rect) : base(rect)
        {
            this.Rectangle = rect;
        }

        public Spline(Spline shape) : base(shape)
        {
        }

        #endregion

        #region Properties

        protected List<PointShape> ControlPoints { get; set; } = new List<PointShape>();

        public override RectangleF Rectangle { get => base.Rectangle; set => base.Rectangle = value; }

        public bool ShowControlPolygon = true;

        public override PointF Location
        {
            get => base.Location;
            set
            {
                // Записва точката която проверяваме дали е в полигона в масив
                PointF[] transformPointsArray = new PointF[] { value };

                // Правим временна матрица на която присвояваме стойността на нашата матрица на Трансофрмация
                Matrix temp = TransformationMatrix.Clone();

                // Инвертираме, за да се върнем обратно в координатната система използвана от програмата
                temp.Invert();

                // Връщаме се в координатната система спомената горе
                temp.TransformPoints(transformPointsArray);

                foreach (PointShape p in ControlPoints)
                {
                    p.Location = new PointF(
                        p.Location.X + value.X - base.Location.X,
                        p.Location.Y + value.Y - base.Location.Y
                    );
                }

                base.Location = value;
            }
        }

        public override float StrokeWidth
        {
            get => base.StrokeWidth;
            set
            {
                base.StrokeWidth = value;
            }
        }

        public override string Name
        {
            get => base.Name;
            set => base.Name = value;
        }

        #endregion

        // Виж в класа на Полигонът

        /// <summary>
        /// Checks if a point is inside the polygon using Ray Casting 
        /// Doesn't matter if it's convex or not
        /// Works O(n) where n is the Vertices Count
        /// </summary>
        /// <param name="point">Mouse (x,y) coordinates</param>
        /// <returns></returns>

        public override bool Contains(PointF point)
        {
            PointF[] transformPointsArray = new PointF[] { point };
            Matrix temp = TransformationMatrix.Clone();

            temp.Invert();

            temp.TransformPoints(transformPointsArray);
            PointF p = transformPointsArray[0];

            return CountIntersections(p, ControlPoints) % 2 == 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            if (ShowControlPolygon)
            {
                List<PointF> points = new List<PointF>();

                if (ControlPoints.Count >= 1)
                {
                    foreach (var item in ControlPoints)
                    {
                        points.Add(item.Location);
                    }
                    grfx.DrawPolygon(Pens.Gray, points.ToArray());
                }
                else
                    grfx.DrawPolygon(Pens.Gray, Points.ToArray());
            }
        }
    }
}
