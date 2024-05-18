using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    [Serializable]
    public class PolygonShape : Polygon
    {
        #region Constructor

        public PolygonShape(RectangleF rect, List<PointShape> vertices) : base(rect)
        {
            this.Vertices = vertices;
        }

        public PolygonShape(PolygonShape polygon) : base(polygon)
        {

        }

        #endregion

        public override Shape Clone()
        {
            return new PolygonShape(this);
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

            List<PointF> convertPoints = new List<PointF>();

            foreach (var item in Vertices)
            {
                convertPoints.Add(new PointF(item.Location.X, item.Location.Y));
            }

            FillColor = Color.FromArgb(Opacity, FillColor);

            grfx.FillPolygon(new SolidBrush(FillColor), convertPoints.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor, StrokeWidth), convertPoints.ToArray());

            grfx.Restore(State);
        }
    }
}
