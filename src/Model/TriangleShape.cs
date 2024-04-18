using Draw.src.Processors;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace Draw.src.Model
{
    public class TriangleShape : Polygon
    {
        #region Constructor

        public TriangleShape(RectangleF rect, List<PointShape> vertices) : base(rect)
        {
            this.Vertices = vertices;
        }

        public TriangleShape(TriangleShape triangle) : base(triangle)
        {

        }

        #endregion

        #region Properties

        public string Type { get; set; }

        #endregion

        public override bool Contains(PointF point)
        {
            return base.ContainsTriangle(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            grfx.FillPolygon(new SolidBrush(FillColor), convertedPoints.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor), convertedPoints.ToArray());

            grfx.Restore(State);
        }
    }
}
