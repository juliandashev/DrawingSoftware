using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        #endregion

        #region Properties

        public List<Shape> GroupShapes = new List<Shape>();

        public override PointF Location
        {
            get => base.Location;
            set
            {
                foreach (Shape item in GroupShapes)
                {
                    item.Location = new PointF(
                        item.Location.X + value.X - base.Location.X,
                        item.Location.Y + value.Y - base.Location.Y
                        ); ;
                }

                base.Location = value;
            }
        }

        public override Color FillColor
        {
            get => base.FillColor;
            set
            {
                foreach (Shape item in GroupShapes)
                {
                    item.FillColor = value;
                }

                base.FillColor = value;
            }
        }

        public override Matrix RotationMatrix
        {
            get => base.RotationMatrix;
            set
            {
                foreach (Shape item in GroupShapes)
                {
                    item.RotationMatrix.Multiply(value);
                }
            }
        }

        public override float Width
        {
            get => base.Width;
            set
            {
                float minX = GroupShapes.Min(x => x.Rectangle.Left);
                float maxX = GroupShapes.Max(x => x.Rectangle.Right);

                base.Width = maxX - minX;
            }
        }

        public override float Height
        {
            get => base.Height;
            set
            {
                float minY = GroupShapes.Min(y => y.Rectangle.Top);
                float maxY = GroupShapes.Max(y => y.Rectangle.Bottom);

                base.Height = maxY - minY;
            }
        }

        public override RectangleF Rectangle
        {
            get => base.Rectangle;
            set
            {
                float minX = GroupShapes.Min(x => x.Rectangle.Left);
                float minY = GroupShapes.Min(y => y.Rectangle.Top);

                base.Rectangle = new RectangleF(minX, minY, Width, Height);
            }
        }

        public override float RotationAngle { get => base.RotationAngle; set => base.RotationAngle = value; }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                foreach (Shape shape in GroupShapes)
                {
                    if (shape.Contains(point))
                        return true;
                }
            }

            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            if (RotationAngle == 0)
            {
                base.DrawSelf(grfx);

                foreach (Shape shape in GroupShapes)
                {
                    shape.DrawSelf(grfx);
                }
            }
            else
            {
                //base.DrawSelf(grfx, RotationAngle);
                State = grfx.Save();

                PointF center = new PointF((this.Width / 2) + this.Rectangle.X, (this.Height / 2) + this.Rectangle.Y);

                RotationMatrix.RotateAt(RotationAngle, center);
                grfx.Transform = RotationMatrix;

                //base.TrnasformPoints(grfx);

                grfx.Restore(State);
            }
        }
    }
}
