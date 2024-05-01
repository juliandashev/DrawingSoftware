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
    public abstract class Spline : Shape
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

        public override PointF Location
        {
            get => base.Location;
            set
            {
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

                if (value < 2)
                    base.StrokeWidth = 2;
            }
        }

        #endregion

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

            // Variable for counting how many walls were intersected
            int count = 0;

            float x1, y1, x2, y2;

            // Lopping through every vertex
            for (int i = 0; i < ControlPoints.Count; i++)
            {
                if (i < ControlPoints.Count - 1)
                {
                    // Definig the x and y of the first point
                    x1 = ControlPoints[i + 1].Location.X;
                    y1 = ControlPoints[i + 1].Location.Y;

                    // Then definig the x and y of the next point
                    x2 = ControlPoints[i].Location.X;
                    y2 = ControlPoints[i].Location.Y;
                }
                else
                {
                    // Finding the values of the last point
                    x1 = ControlPoints[i].Location.X;
                    y1 = ControlPoints[i].Location.Y;

                    // Finding the values of the first point
                    x2 = ControlPoints[0].Location.X;
                    y2 = ControlPoints[0].Location.Y;
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
            base.DrawSelf(grfx);

            List<PointF> points = new List<PointF>();

            foreach (var item in ControlPoints)
            {
                points.Add(item.Location);
            }

            grfx.DrawPolygon(Pens.Gray, points.ToArray());
        }
    }
}
