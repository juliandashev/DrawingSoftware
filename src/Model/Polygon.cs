using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
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
            rectangle = rect;
        }

        public Polygon(Polygon polygon) : base(polygon)
        {
            this.Height = polygon.Height;
            this.Width = polygon.Width;
            this.Location = polygon.Location;
            this.rectangle = polygon.rectangle;

            this.FillColor = polygon.FillColor;
            this.StrokeColor = polygon.StrokeColor;
        }

        #endregion

        #region Properties

        private List<PointF> vertices = new List<PointF>();
        public List<PointF> Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        private RectangleF rectangle;
        public override RectangleF Rectangle
        {
            get => rectangle;
            set => rectangle = value;
        }

        public override PointF Location
        {
            get => Rectangle.Location;
            set => rectangle.Location = value;
        }

        public override float Width
        {
            get => Rectangle.Width;
            set => rectangle.Width = value;
        }

        public override float Height
        {
            get => Rectangle.Height;
            set => rectangle.Height = value;
        }

        #endregion
    }
}
