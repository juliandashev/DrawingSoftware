using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
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
        PointF[] NTagonPoints { get; set; }

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
            PointF[] transformPointsArray = new PointF[] { point };

            Matrix temp = TransformationMatrix.Clone();

            temp.Invert();

            temp.TransformPoints(transformPointsArray);
            PointF p = transformPointsArray[0];

            // Variable for counting how many walls were intersected
            int count = 0;

            float x1, y1, x2, y2;

            // Lopping through every vertex
            for (int i = 0; i < NTagonPoints.Length; i++)
            {
                if (i < NTagonPoints.Length - 1)
                {
                    // Definig the x and y of the first point
                    x1 = NTagonPoints[i + 1].X;
                    y1 = NTagonPoints[i + 1].Y;

                    // Then definig the x and y of the next point
                    x2 = NTagonPoints[i].X;
                    y2 = NTagonPoints[i].Y;
                }
                else
                {
                    // Finding the values of the last point
                    x1 = NTagonPoints[i].X;
                    y1 = NTagonPoints[i].Y;

                    // Finding the values of the first point
                    x2 = NTagonPoints[0].X;
                    y2 = NTagonPoints[0].Y;
                }

                // Two conditions have to be met

                // First condition ensures that the point is between the two points on the y coordinates of the lines of the polygon
                bool firstCondition = (p.Y > y2) != (p.Y > y1);

                // Everything is calculated with respect of this coordinate system (with inverted y axis)

                // Second condition's formula is derived from trying to find first x0 = x1 + ?
                // x0 is the intersection of the line of our edge
                // We have to check if point's X coordinate is smaller than x0. This would mean that mouses X coordinate crosses

                // First we know that the length from the origin to the edge we are at is = x2 also known as offset

                // x0 depends on the value of Yp, changeing it changes the value of x0
                // we need to calculate the ratio between the height of our point (yp - y2) and the height of our edge (y1 - y2) this gives a value between [0;1]
                // and then multiplying by the width of the edge (x1 - x2) to see how much x we add to x2

                // and thats how we derived xp = x0 = x2 + ((point.Y - y2) / (y1 - y2)) * (x1 - x2)
                // lastly we take the < sign because we are aiming to be on the left side of the line

                bool secondCondition = p.X < x2 + ((p.Y - y2) / (y1 - y2)) * (x1 - x2);

                if (firstCondition && secondCondition)
                    // Then the number of crossed edges increases
                    count++;
            }

            // Return true if its an odd number and false if its an even
            // odd meaning - inside the polygon
            // even meaning - outside the polygon
            return count % 2 == 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            FillColor = Color.FromArgb(Opacity, FillColor);

            this.NTagonPoints = MakeNTagonPoints(this.NumberOfPoints);

            grfx.FillPolygon(new SolidBrush(FillColor), this.NTagonPoints);
            grfx.DrawPolygon(new Pen(StrokeColor, StrokeWidth), this.NTagonPoints);

            grfx.Restore(State);
        }

        private PointF[] MakeNTagonPoints(int numPoints)
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

            return points;
        }
    }
}
