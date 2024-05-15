using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class BSplineShape : Spline
    {
        #region Constructors

        public BSplineShape(RectangleF rect, List<PointShape> controlPoints) : base(rect)
        {
            ControlPoints = controlPoints;
        }

        public BSplineShape(RectangleF rect, List<PointF> controlPoints) : base(rect)
        {
            Points = controlPoints;
        }

        public BSplineShape(RectangleF rect) : base(rect)
        {

        }

        public BSplineShape(BSplineShape shape) : base(shape)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// This is the degree of the spline, hardcoded to 3 because often this used everywhere
        /// </summary>
        public const int p = 3;

        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            if (ControlPoints.Count >= p + 1 || Points.Count >= p + 1)
            {
                PointF[] curvePoints;

                if (ControlPoints.Count >= 0)
                {
                    foreach (PointShape point in ControlPoints)
                        Points.Add(point.Location);
                }

                curvePoints = CalculateBSplineCurve(Points);
                FillColor = Color.FromArgb(Opacity, FillColor);

                grfx.DrawLines(new Pen(FillColor, StrokeWidth), curvePoints);
                Points.Clear();
            }
        }

        private PointF[] CalculateBSplineCurve(List<PointF> controlPoints)
        {
            List<PointF> curvePoints = new List<PointF>();

            float[] knotVector = GenerateKnotVector(controlPoints.Count - 1);

            //int len = m.Length - 2 * p;

            for (float u = 0; u <= 1; u += 0.001f)
            {
                PointF point = new PointF();

                // Calculate Point
                for (int i = 0; i < controlPoints.Count; i++)
                {
                    float baseFunction = N(i, p, knotVector, u);

                    point.X += baseFunction * controlPoints[i].X;
                    point.Y += baseFunction * controlPoints[i].Y;
                }

                //grfx.DrawEllipse(Pens.Blue, point.X - 2, point.Y - 2, 5, 5);
                curvePoints.Add(point);
            }

            return curvePoints.ToArray();
        }

        // Cox-deBoor's formula for computing b spline functions
        private float N(int i, int p, float[] knotVector, float u)
        {
            if (knotVector[knotVector.Length - 1] == u) // to remove some special cases and to skip the recursive calls for u = 1
                return 1;

            // the base case for the recursive formula is
            // N(u)i,0 = 1 if u[i] <= u < u[i+1] and 0 otherwise
            if (p == 0) // base case
            {
                if ((knotVector[i] <= u && u < knotVector[i + 1]))
                    // Base B Splain functions are N(0,n,u), N(1,n,u), ... , N(n,n,u)
                    return 1;
                return 0;
            }

            if (knotVector[i] <= u && u < knotVector[i + p + 1]) // thats a property of non-zero base function, also it speeds up the code
            {
                float leftSide = 0;
                float rightSide = 0;

                if ((knotVector[i + p] - knotVector[i]) != 0)
                    leftSide = ((u - knotVector[i]) /
                        (knotVector[i + p] - knotVector[i]))
                            * N(i, p - 1, knotVector, u);

                if ((knotVector[i + p + 1] - knotVector[i + 1]) != 0)
                    rightSide = ((knotVector[i + p + 1] - u) /
                        (knotVector[i + p + 1] - knotVector[i + 1]))
                            * N(i + 1, p - 1, knotVector, u);

                return leftSide + rightSide;
            }

            return 0;
        }

        private float[] GenerateKnotVector(int n)
        {
            int m = n + p + 1; // number of knots is defined by this equation

            int index = m - p; // this is needed to find the knot that should be equal to 1 to close the curve on the other side 

            // if the knots are 13 their count is 14 because of the u at 0th index
            float[] knotVector = new float[++m];

            int divisor = m - (2 * p); // this is needed to divide evenly the free knots; +1 so that there is no n/n knot which would equal 1

            for (int i = 0; i < m; i++)
            {
                if (i <= p) // closing the curve on the left side
                    knotVector[i] = 0;
                else if (i >= index) // closing the curve on the right side
                    knotVector[i] = 1;
                else
                    knotVector[i] = (float)(i - p + 1) / divisor; // (n-p)
            }

            return knotVector;
        }
    }
}
