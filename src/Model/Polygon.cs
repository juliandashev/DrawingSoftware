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
    public abstract class Polygon
    {
        #region Constructors
        public Polygon()
        {
            
        }
        public Polygon(RectangleF rect)
        {
            rectangle = rect;
        }

        public Polygon(Polygon polygon)
        {
            this.Height = polygon.Height;
            this.Width = polygon.Width;
            this.Location = polygon.Location;
            this.rectangle = polygon.rectangle;

            this.FillColor = polygon.FillColor;
        }

        #endregion
        #region Properties

        private RectangleF rectangle;
        public virtual RectangleF Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }

        public virtual float Width
        {
            get { return Rectangle.Width; }
            set { rectangle.Width = value; }
        }

        public virtual float Height
        {
            get { return Rectangle.Height; }
            set { rectangle.Height = value; }
        }

        public virtual PointF Location
        {
            get { return Rectangle.Location; }
            set { rectangle.Location = value; }
        }

        private Color fillColor;
        public virtual Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        private Color strokeColor;
        public virtual Color StrokeColor
        {
            get { return strokeColor; }
            set { strokeColor = value; }
        }

        //private List<PointF> vertices;
        //public List<PointF> Vertices
        //{
        //    get { return vertices; }
        //    set { vertices = value; }
        //}

        #endregion

        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {
            // shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
        }
    }
}
