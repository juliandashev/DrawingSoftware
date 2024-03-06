using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class PolygonShape : Shape
    {
        #region Constructor
        
        public PolygonShape(List<PointF> vertices)
        {
            Vertices = vertices;
        }

        #endregion

        public override bool Contains(PointF point)
        {
            Dictionary<PointF, PointF> edges = new Dictionary<PointF, PointF>();

            for (int i = 0; i < Vertices.Count - 1; i++)
            {
                edges.Add(Vertices[i], Vertices[i + 1]);
            }



            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillPolygon(new SolidBrush(FillColor), Vertices.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor), Vertices.ToArray());
        }
    }
}
