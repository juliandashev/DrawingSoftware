using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    [Serializable]
    public abstract class Polygon : Shape
    {
        #region Constructors
        public Polygon()
        {

        }
        public Polygon(RectangleF rect) : base(rect)
        {

        }

        #endregion

        #region Properties

        private List<PointF> vertices;
        public List<PointF> Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        #endregion
    }
}
