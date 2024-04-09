using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(EllipseShape shape) : base(shape)
        {
        }

        #endregion

        // Cool thing is that this could be used for the circle primitive as well 
        public override bool Contains(PointF point)
        {
            // calculating the half width and half height of the Rectangle
            float halfWidth = Rectangle.Width / 2;
            float halfHeight = Rectangle.Height / 2;

            // Find the center of the ellipse using the Rectangle.Left prop
            // by getting the left edge and addding the halfwidth we are getting the x coordinate of the center
            // similliar thing applies to the y coordinate
            PointF ellipseCenter = new PointF(
                Rectangle.Left + halfWidth,
                Rectangle.Top + halfHeight);
            
            // basically returning the formula
            // ((x-h) / rx)^2 + ((y-h) / ry)^2 <= 1
            // where < 1 is inside the ellipse and = 1 means on the line
            return 
                Math.Pow((point.X - ellipseCenter.X) / halfWidth, 2) +
                Math.Pow((point.Y - ellipseCenter.Y) / halfHeight, 2) 
                    <= 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.Restore(State);
        }
    }
}
