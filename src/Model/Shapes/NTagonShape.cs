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
    public class NTagonShape : Polygon // Това включва Хексагон, Пентагон и т.н.
    {
        #region Constructor

        public NTagonShape(RectangleF rect, int numberOfPoints) : base(rect)
        {
            this.NumberOfPoints = numberOfPoints;
        }

        public NTagonShape(NTagonShape nTagon) : base(nTagon)
        {
        }

        #endregion

        #region Properties

        private int NumberOfPoints { get; set; } = 6;

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

        public override Shape Clone()
        {
            return new NTagonShape(this);
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            FillColor = Color.FromArgb(Opacity, FillColor);

            Points = MakeNTagonPoints(this.NumberOfPoints);

            grfx.FillPolygon(new SolidBrush(FillColor), Points.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor, StrokeWidth), Points.ToArray());

            grfx.Restore(State);
        }

        private List<PointF> MakeNTagonPoints(int numPoints)
        {
            PointF[] points = new PointF[numPoints];

            float rx = Rectangle.Width / 2f;
            float ry = Rectangle.Height / 2f;

            float cx = Rectangle.X + rx;
            float cy = Rectangle.Y + ry;

            float r = 70; // Circle radius

            double theta = -Math.PI / 2;
            double deltaTheta = 2 * Math.PI / numPoints;

            for (int i = 0; i < numPoints; i++)
            {
                // From Polar Coordinates
                // x = r * cos (Theta) 
                // y = r * sin (Theta)

                points[i] = new PointF(
                    cx + r * (float)Math.Cos(theta),
                    cy + r * (float)Math.Sin(theta)
                    );

                theta += deltaTheta;
            }

            return points.ToList();
        }
    }
}
