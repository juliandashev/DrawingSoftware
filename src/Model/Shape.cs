using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public abstract class Shape
    {
        #region Constructors

        public Shape()
        {
        }

        public Shape(RectangleF rect)
        {
            rectangle = rect;
        }

        public Shape(Shape shape)
        {
            this.Height = shape.Height;
            this.Width = shape.Width;
            this.Location = shape.Location;
            this.rectangle = shape.rectangle;

            this.FillColor = shape.FillColor;
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

        private Matrix rotationMatrix;

        public Matrix RotationMatrix
        {
            get { return rotationMatrix; }
            set { rotationMatrix = value; }
        }

        private float rotationAngle;

        public float RotationAngle
        {
            get { return rotationAngle; }
            set { rotationAngle = value; }
        }

        public GraphicsState State { get; set; }

        #endregion

        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {
            // shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
        }

        /// <summary>
        /// Ротация в градуси спрямо центъра на фигурата
        /// </summary>
        /// <param name="grfx"></param>
        /// <param name="rotationAngle"> Ъгъл на ротация в градуси, може да приема и отрицателни стойности</param>
        public virtual void DrawSelf(Graphics grfx, float rotationAngle)
        {
            State = grfx.Save();
        }

        public virtual void TrnasformPoints(Graphics grfx)
        {
            PointF[] transformationPoints = new PointF[4]
            {
                new PointF(Rectangle.Left, Rectangle.Top),
                new PointF(Rectangle.Right, Rectangle.Top),
                new PointF(Rectangle.Left, Rectangle.Bottom),
                new PointF(Rectangle.Right, Rectangle.Bottom)
            };

            grfx.TransformPoints(CoordinateSpace.Page, CoordinateSpace.World, transformationPoints);
        }
    }
}
