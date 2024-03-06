using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class TriangleShape : Shape
    {
        #region Constructor

        public TriangleShape(List<PointF> vertices)
        {
            Vertices = vertices;
        }

        #endregion

        // TODO: Baricentric approach seems promising, do it later
        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public bool isValid()
        {
            PointF ABVector = new PointF(Vertices[1].X - Vertices[0].X, Vertices[1].Y - Vertices[0].Y);
            PointF ACVector = new PointF(Vertices[2].X - Vertices[0].X, Vertices[2].Y - Vertices[0].Y);

            float det = (ABVector.X * ACVector.Y) - (ABVector.Y * ACVector.X);

            return det != 0;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillPolygon(new SolidBrush(FillColor), Vertices.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor), Vertices.ToArray());
        }
    }
}
