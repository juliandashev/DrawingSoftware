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

            // Needs to be fixed
            float x = Rectangle.X;
            float y = Rectangle.Y;
            float width = Rectangle.Width;
            float height = Rectangle.Height;

            List<PointF> firstHalfPoints = new List<PointF>()
            {
                new PointF(x + width * 0.5f, y + height * 0.2f),

                new PointF(x + width * 0.9f, y),
                new PointF(x + width, y + height * 0.4f),
                new PointF(x + width * 0.8f, y + height * 0.6f),

                new PointF(x + width * 0.5f, y + height)
            };

            List<PointF> secondHalfPoints = new List<PointF>()
            {
                new PointF(x + width * 0.5f, y + height),

                new PointF(x + width * 0.2f, y + height * 0.6f),
                new PointF(x, y + height * 0.4f),
                new PointF(x + width * 0.1f, y),

                new PointF(x + width * 0.5f, y + height * 0.2f)
            };

            BSplineShape bspline = new BSplineShape(Rectangle);
            bspline.Points = firstHalfPoints;

            bspline.ShowControlPolygon = false;

            bspline.DrawSelf(grfx);

            bspline.Points = secondHalfPoints;
            bspline.DrawSelf(grfx);

            grfx.Restore(State);
        }
    }
}
