using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class SplineShape : Shape
    {
        #region Constructors

        public SplineShape(RectangleF rect, List<PointF> controlPoints) : base(rect)
        {
            this.ControlPoints = controlPoints;
        }

        public SplineShape(SplineShape shape) : base(shape)
        {
        }

        #endregion

        #region Properties

        private List<PointF> controlPoints = new List<PointF>();
        private List<PointF> ControlPoints
        {
            get => controlPoints;
            set => controlPoints = value;
        }

        /// <summary>
        /// This is the degree of the spline, hardcoded to 3 because often this used everywhere
        /// </summary>
        public const int p = 4;

        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            if (controlPoints.Count >= p + 1)
            {
                PointF[] curvePoints = CalculateBSplineCurve(controlPoints, p, 100, grfx);
                grfx.DrawLines(new Pen(StrokeColor, 2), curvePoints);
            }
        }

        private PointF[] CalculateBSplineCurve(List<PointF> controlPoints, int p, int numberOfPoints, Graphics grfx)
        {
            List<PointF> curvePoints = new List<PointF>();

            float[] m = GenerateKnotVector(controlPoints.Count - 1, p);

            for (int i = 0; i < numberOfPoints; i++)
            {
                float u = (float)i / (numberOfPoints - 1);

                PointF point = CalculateBSplinePoint(controlPoints, p, m, u);
                grfx.DrawEllipse(Pens.Blue, point.X - 2, point.Y - 2, 5, 5);
                curvePoints.Add(point);
            }

            return curvePoints.ToArray();
        }

        private PointF CalculateBSplinePoint(List<PointF> controlPoints, int p, float[] m, float u)
        {
            PointF point = new PointF();

            for (int i = 0; i < controlPoints.Count - 1; i++)
            {
                float baseSplineFunc = N(i, p, m, u);

                point.X += baseSplineFunc * controlPoints[i].X;
                point.Y += baseSplineFunc * controlPoints[i].Y;
            }

            return point;
        }

        // Memoization to fix the redundant recursive calls 
        private Dictionary<string, float> memizationCache = new Dictionary<string, float>();

        // Cox-deBoor's formula for computing b spline functions
        private float N(int i, int p, float[] knotVector, float u)
        {
            if (u == 1) 
                return 1;

            string cacheKey = $"{i}-{p}-{u}";

            if (memizationCache.ContainsKey(cacheKey))
            {
                return memizationCache[cacheKey];
            }

            float result;

            // the base case for the recursive formula is

            // N(u)i,0 = 1 if u[i] <= u < u[i+1] and 0 otherwise

            if (p == 0) // base case
            {
                if (knotVector[i] <= u && u < knotVector[i + 1]) // a special case where u0 = ... = un = 0 and u(n+1) = ... = u(2n + 1) = 1
                    // Base B Splain functions are N(0,n,u), N(1,n,u), ... , N(n,n,u)
                    return 1;
                return 0;
            }

            float leftSide = 0, rightSide = 0;

            if (knotVector[i + p] - knotVector[i] != 0) // checks to make sure there is no zero division
                leftSide = ((u - knotVector[i]) / (knotVector[i + p] - knotVector[i])) * N(i, p - 1, knotVector, u);

            if (knotVector[i + p + 1] - knotVector[i + 1] != 0) // same thing as well
                rightSide = ((knotVector[i + p + 1] - u) / (knotVector[i + p + 1] - knotVector[i + 1])) * N(i + 1, p - 1, knotVector, u);

            // store the result in the cache
            memizationCache[cacheKey] = result = leftSide + rightSide;

            return result;
        }

        private float[] GenerateKnotVector(int n, int p)
        {
            int m = n + p + 1; // number of knots is defined by this equation
            float[] knotVector = new float[m];

            for (int i = 0; i < m; i++)
            {
                if (i <= p) // closing the curve on the left side
                    knotVector[i] = 0;
                else if (i >= n) // closing the curve on the right side
                    knotVector[i] = 1;
                else
                    knotVector[i] = (float)(i - p) / (n - p);
            }

            return knotVector;
        }
    }
}
