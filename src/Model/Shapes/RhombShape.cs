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
    public class RhombShape : Polygon
    {

        #region Constructor

        public RhombShape(RectangleF rect) : base(rect)
        {
        }

        public RhombShape(RhombShape rhomb) : base(rhomb)
        {
        }

        #endregion

        #region Properties

        #endregion

        public override Shape Clone()
        {
            return new RhombShape(this);
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

            Points = new List<PointF>
                {
                        new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y),
                        new PointF(Rectangle.Right, Rectangle.Y + Rectangle.Height / 2),
                        new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Bottom),
                        new PointF(Rectangle.X, Rectangle.Y + Rectangle.Height / 2)
                };

            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Opacity, FillColor)), Points.ToArray());
            grfx.DrawPolygon(new Pen(Color.FromArgb(Opacity, StrokeColor), StrokeWidth), Points.ToArray());

            grfx.Restore(State);
        }
    }
}
