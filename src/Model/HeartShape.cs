using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class HeartShape : Shape
    {
        public HeartShape(RectangleF rect) : base(rect)
        {
        }

        #region Constructor

        #endregion

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
            float w = Rectangle.Width;
            float h = Rectangle.Height;

            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x + w * 0.5f, y + h * 0.1f,
                           x + w * 0.9f, y,
                           x + w, y + h * 0.4f,
                           x + w * 0.5f, y + h);

            path.AddBezier(x + w * 0.5f, y + h,
                           x, y + h * 0.4f,
                           x + w * 0.1f, y,
                           x + w * 0.5f, y + h * 0.1f);

            grfx.FillPath(new SolidBrush(FillColor), path);
            grfx.DrawPath(new Pen(StrokeColor, StrokeWidth), path);
            
            grfx.Restore(State);
        }
    }
}
