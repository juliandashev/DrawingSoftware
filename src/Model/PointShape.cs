using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class PointShape : RectangleShape
    {
        #region Constructors
        public PointShape(RectangleF rect) : base(rect)
        {

        }

        public PointShape(PointShape point) : base(point)
        {
        }
        #endregion

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            //PointF center = new PointF(
            //    (Rectangle.Width / 2) + Rectangle.X,
            //    (Rectangle.Height / 2) + Rectangle.Y);

            //Vertices.Add(center);
        }
    }
}
