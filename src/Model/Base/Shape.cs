﻿using Draw.src.Processors.Helper;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Draw
{
    [Serializable]
    // [JsonConverter(typeof(BaseConverter))]
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
            this.StrokeColor = shape.StrokeColor;
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
            set
            {
                rectangle.Location = value;
            }
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

        private float strokeWidth = 1;
        public virtual float StrokeWidth
        {
            get { return strokeWidth; }
            set { strokeWidth = value; }
        }

        private int opacity = 255;
        public virtual int Opacity
        {
            get { return opacity; }
            set { opacity = value; }
        }

        //private MatrixSerializable _transform;

        private Matrix transformationMatrix = new Matrix();

        [JsonConverter(typeof(MatrixConverter))]
        public virtual Matrix TransformationMatrix
        {
            get => transformationMatrix;
            set => transformationMatrix = value;
        }

        //public virtual Matrix TransformationMatrix
        //{
        //    get => transformationMatrix ?? (transformationMatrix = _transform?.GetMatrix());
        //    set
        //    {
        //        transformationMatrix = value;
        //        _transform = new MatrixSerializable(value);
        //    }
        //}

        [NonSerialized]
        public GraphicsState state;

        public GraphicsState State
        {
            get => state;
            set
            {
                state = value;
            }
        }

        private string name;
        public virtual string Name
        {
            get { return name; }

            set { name = value; }
        }
        #endregion

        public virtual bool Contains(PointF point)
        {
            PointF[] transformPointsArray = new PointF[] { point };

            Matrix temp = TransformationMatrix.Clone();

            temp.Invert();

            temp.TransformPoints(transformPointsArray);

            return Rectangle.Contains(transformPointsArray[0].X, transformPointsArray[0].Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {
            Font defaultFont = SystemFonts.DefaultFont;
            grfx.DrawString(Name, defaultFont, new SolidBrush(Color.Black), new PointF(Rectangle.Right, Rectangle.Bottom));
            // shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
        }

        public abstract Shape Clone();
    }
}
