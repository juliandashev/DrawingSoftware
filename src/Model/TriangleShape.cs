using Draw.src.Processors;
using Draw.src.Processors.Helper;
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

            List<PointF> convertedPoints = new List<PointF>();
            
            foreach (var item in Vertices)
            {
                convertedPoints.Add(new PointF(item.Location.X, item.Location.Y));
            }

            grfx.FillPolygon(new SolidBrush(FillColor), convertedPoints.ToArray());
            grfx.DrawPolygon(new Pen(StrokeColor), convertedPoints.ToArray());

            grfx.Restore(State);
        }
    }
}
