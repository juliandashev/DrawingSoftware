using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class BezierCurveShape : Shape
    {
        #region Constructors

        public BezierCurveShape(RectangleF rect, List<PointF> controlPoints) : base(rect)
        {
            this.ControlPoints = controlPoints;
        }

        public BezierCurveShape(BezierCurveShape shape) : base(shape)
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

        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            for (float u = 0; u <= 1; u += 0.001f)
            {
                PointF curvePoint = ComputeCasteljauPoint(controlPoints.Count - 1, 0, u);
                grfx.DrawLine(new Pen(StrokeColor), curvePoint, curvePoint);
            }
        }

        // Try with Bernstein polynomial!!!

        private PointF ComputeCasteljauPoint(int r, int i, float u)
        {
            if (r == 0) return controlPoints[i];

            PointF p1 = ComputeCasteljauPoint(r - 1, i, u);
            PointF p2 = ComputeCasteljauPoint(r - 1, i + 1, u);

            return new PointF((1 - u) * p1.X + u * p2.X, (1 - u) * p1.Y + u * p2.Y);
        }
    }
}
