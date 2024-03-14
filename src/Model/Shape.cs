﻿using System;
using System.Collections.Generic;
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
            this.vertices = shape.Vertices;
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

        private List<PointF> vertices;

        public List<PointF> Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        private Matrix transformationMatrix;

        public Matrix TransformationMatrix
        {
            get { return transformationMatrix; }
            set { transformationMatrix = value; }
        }

        private float rotationAngle;

        public float RotationAngle
        {
            get { return rotationAngle; }
            set { rotationAngle = value; }
        }

        #endregion

        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {
            // shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
        }
        public virtual void DrawSelf(Graphics grfx, float rotationAngle)
        {
            
        }
    }
}
