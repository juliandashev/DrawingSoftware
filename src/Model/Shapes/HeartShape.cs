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
    public class HeartShape : Shape
    {
        public HeartShape(RectangleF rect) : base(rect)
        {
        }

        public HeartShape(HeartShape heartShape) : base(heartShape)
        {

        }

        #region Constructor

        #endregion

        public override Shape Clone()
        {
            return new HeartShape(this);
        }

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

            float x = Rectangle.X;
            float y = Rectangle.Y;
            float width = Rectangle.Width;
            float height = Rectangle.Height;

            // Points on the right side
            PointF p1 = new PointF(x + width * 0.5f, y + height * 0.2f);

            PointF p2 = new PointF(x + width * 0.9f, y);
            PointF p3 = new PointF(x + width, y + height * 0.4f);

            PointF p4 = new PointF(x + width * 0.5f, y + height);

            GraphicsPath path = new GraphicsPath();

            path.AddBezier(p1, p2, p3, p4);

            // Points on the left side
            PointF _p1 = new PointF(x + width * 0.5f, y + height);

            PointF _p2 = new PointF(x, y + height * 0.4f);
            PointF _p3 = new PointF(x + width * 0.1f, y);

            PointF _p4 = new PointF(x + width * 0.5f, y + height * 0.2f);

            path.AddBezier(_p1, _p2, _p3, _p4);

            grfx.FillPath(new SolidBrush(FillColor), path);
            grfx.DrawPath(new Pen(StrokeColor, StrokeWidth), path);

            grfx.Restore(State);
        }
    }
}
