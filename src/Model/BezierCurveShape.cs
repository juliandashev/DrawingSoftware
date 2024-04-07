using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class BezierCurveShape : Shape
    {
        #region Constructors

        public BezierCurveShape(RectangleF rect) : base(rect)
        {
        }

        public BezierCurveShape(BezierCurveShape shape, List<PointF> controlPoints) : base(shape)
        {
            this.ControlPoints = controlPoints;
        }

        #endregion

        #region Properties

        private List<PointF> ControlPoints { get; set; }

        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.DrawBezier(new Pen(StrokeColor, 2),
                ControlPoints[0], ControlPoints[1], ControlPoints[2], ControlPoints[3]);
        }
    }
}
