﻿using Draw.src.Model;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class RectangleShape : Shape
    {
        #region Constructor

        public RectangleShape(RectangleF rect) : base(rect)
        {
        }

        public RectangleShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion

        #region Properties


        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то не може да е в обекта и => false
                return false;
        }

        public override Shape Clone()
        {
            return new RectangleShape(this);
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            FillColor = Color.FromArgb(Opacity, FillColor);

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(StrokeColor, StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.Restore(State);
        }
    }
}
