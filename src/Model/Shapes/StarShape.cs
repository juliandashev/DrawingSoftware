using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class StarShape : Polygon
    {
        #region Constructor

        public StarShape(RectangleF rect) : base(rect)
        {
        }

        public StarShape(StarShape star) : base(star)
        {

        }

        #endregion

        #region Properties

        private int NumberOfPoints { get; set; } = 5;

        #endregion

        /// <summary>
        /// Checks if a point is inside the polygon using Ray Casting.
        /// </summary>
        /// <param name="point">Mouse (x,y) coordinates</param>
        /// <returns></returns>

        // Doesn't matter if it's convex or not.
        // Works O(n) where n is the Vertices Count
        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            FillColor = Color.FromArgb(Opacity, FillColor);

            Points = MakeStarPoints(this.NumberOfPoints);

            grfx.FillPolygon(new SolidBrush(FillColor), Points.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor, StrokeWidth), Points.ToArray());

            grfx.Restore(State);
        }

        private List<PointF> MakeStarPoints(int numPoints)
        {
            PointF[] points = new PointF[numPoints * 2];

            float rx = Rectangle.Width / 2;
            float ry = Rectangle.Height / 2;

            float cx = Rectangle.X + rx;
            float cy = Rectangle.Y + ry;

            float outherRadius = Math.Min(Rectangle.Width, Rectangle.Height) / 2;
            float innerRadius = outherRadius * 0.4f;

            double angle = -Math.PI / 2;
            double deltaAngle = Math.PI / numPoints;

            for (int i = 0; i < 2 * numPoints; i++)
            {
                if (i % 2 == 0)
                {
                    points[i] = new PointF(
                        cx + (float)(Math.Cos(angle) * outherRadius),
                        cy + (float)(Math.Sin(angle) * outherRadius)
                    );
                }
                else
                {
                    points[i] = new PointF(
                         cx + (float)(Math.Cos(angle) * innerRadius),
                         cy + (float)(Math.Sin(angle) * innerRadius)
                     );
                }

                angle += deltaAngle;
            }

            return points.ToList();
        }
    }
}