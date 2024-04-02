using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    public class SubShapes : Shape
    {
        #region Constructors
        public SubShapes()
        {

        }

        public SubShapes(RectangleF rect) : base(rect)
        {
            this.Rectangle = rect;
        }

        #endregion

        #region Properties

        public List<Shape> SubShapesList = new List<Shape>();

        public override RectangleF Rectangle
        {
            get => base.Rectangle;
            set
            {
                base.Rectangle = value;
            }
        }

        public override PointF Location
        {
            get => base.Location;
            set
            {
                foreach (var item in SubShapesList)
                {
                    item.Location = new PointF(
                        item.Location.X + value.X - base.Location.X,
                        item.Location.Y + value.Y - base.Location.Y
                    );
                }

                base.Location = value;
            }
        }

        public override float Height
        {
            get => base.Height;
            set
            {
                float maxY = SubShapesList.Max(y => y.Rectangle.Bottom);
                float minY = SubShapesList.Min(y => y.Rectangle.Top);

                base.Height = maxY - minY;
            }
        }
        public override float Width
        {
            get => base.Width;
            set
            {
                float minX = SubShapesList.Min(x => x.Rectangle.Left);
                float maxX = SubShapesList.Max(x => x.Rectangle.Right);

                base.Width = maxX - minX;
            }
        }

        public override Color FillColor
        {
            get => base.FillColor;
            set
            {
                foreach (var item in SubShapesList)
                {
                    item.FillColor = value;
                }
            }
        }
        public override Color StrokeColor
        {
            get => base.StrokeColor;
            set
            {
                foreach (var item in SubShapesList)
                    item.StrokeColor = value;
            }
        }

        public override Matrix TransformationMatrix
        {
            get => base.TransformationMatrix;
            set
            {
                base.TransformationMatrix = value;
            }
        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                foreach (Shape shape in SubShapesList)
                {
                    if (shape.Contains(point))
                        return true;
                }
            }

            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach (Shape shape in SubShapesList)
            {
                shape.DrawSelf(grfx);
            }
        }
    }
}
