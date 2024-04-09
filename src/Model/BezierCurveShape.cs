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

            // grfx.DrawBeziers(new Pen(StrokeColor, 2), controlPoints.ToArray());

            if (controlPoints.Count >= 2)
            {
                PointF[] curvePoints = CalculateBezierCurve(controlPoints, 100);
                grfx.DrawLines(new Pen(StrokeColor, 2), curvePoints);
            }
        }

        private PointF[] CalculateBezierCurve(List<PointF> controlPoints, int numberOfPoints)
        {
            PointF[] curvePoints = new PointF[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++)
            {
                float t = (float)i / (numberOfPoints - 1);
                curvePoints[i] = CalculateBezierPoint(controlPoints, t);
            }

            return curvePoints;
        }

        private PointF CalculateBezierPoint(List<PointF> controlPoints, float t)
        {
            if (controlPoints.Count == 1)
            {
                return controlPoints[0];
            }

            List<PointF> newControlPoints = new List<PointF>();

            for (int i = 0; i < controlPoints.Count - 1; i++)
            {
                float x = (1 - t) * controlPoints[i].X + t * controlPoints[i + 1].X;
                float y = (1 - t) * controlPoints[i].Y + t * controlPoints[i + 1].Y;
                newControlPoints.Add(new PointF(x, y));
            }

            return CalculateBezierPoint(newControlPoints, t);
        }
    }
}
