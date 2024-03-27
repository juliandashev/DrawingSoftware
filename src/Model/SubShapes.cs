using System;
using System.Collections.Generic;
using System.Drawing;
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
        }

        #endregion

        #region Properties

        public List<Shape> GroupShapes = new List<Shape>();

        public override PointF Location 
        { 
            get => base.Location;
            set 
            {
                foreach (Shape shape in GroupShapes)
                {
                    // TODO: Need fixing
                    shape.Location = value;
                }
            } 
        }

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
            base.DrawSelf(grfx);

            foreach (Shape shape in GroupShapes)
            {
                shape.DrawSelf(grfx);
            }
        }
    }
}
