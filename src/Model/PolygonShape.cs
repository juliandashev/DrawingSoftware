using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class PolygonShape : Polygon
    {
        #region Constructor

        public PolygonShape(RectangleF rect, List<PointF> vertices) : base(rect)
        {
            Vertices = vertices;
        }

        #endregion

        #region Properties

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
            // Variable for counting how many walls were intersected
            int count = 0;

            // Lopping through every vertex
            for (int i = 0; i < Vertices.Count - 1; i++)
            {
                // Definig the x and y of the first point
                float x1 = Vertices[i].X;
                float y1 = Vertices[i].Y;

                // Then definig the x and y of the next point
                float x2 = Vertices[i + 1].X;
                float y2 = Vertices[i + 1].Y;

                // Two conditions have to be met

                // First condition ensures that the point is between the two points on the y coordinates of the lines of the polygon
                bool firstCondition = (point.Y < y1) != (point.Y < y2);
                // Second condition's formula is derived from trying to find first x0 = x1 + ?
                // x0 is the intersection of the line of our edge
                // We have to check if point's X coordinate is smaller than x0. This would mean that mouses X coordinate crosses

                // First we know that the length from the origin to the edge we are at is = x1 also known as offset

                // x0 depends on the value of Yp, changeing it changes the value of x0
                // we need to calculate the ratio between the height of our point (yp - y1) and the height of our edge (y2 - y1) this gives a value between [0;1]
                // and then multiplying by the width of the edge (x2 - x1) to see how much x we add to x1

                // and thats how we derived x0 = x1 + ((point.Y - y1) / (y2 - y1)) * (x2 - x1)
                // lastly we take the > sign because we are aiming to be on the left side of the line

                bool secondCondition = point.X > x1 + ((point.Y - y1) / (y2 - y1)) * (x2 - x1);

                if(firstCondition && secondCondition) 
                    // Then the number of crossed edges increases
                    count++;
            }

            // Return true if its an odd number and false if its an even
            // odd meaning - inside the polygon
            // even meaning - outsied the polygon
            return count % 2 == 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            grfx.FillPolygon(new SolidBrush(FillColor), Vertices.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor), Vertices.ToArray());

            grfx.Restore(State);
        }
    }
}
