using Draw.src.Model;
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
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            var state = grfx.Save();

            float sin = (float)Math.Sin(90);
            float cos = (float)Math.Cos(90);

            Matrix rotation = new Matrix(cos, sin, sin * -1, cos, 0, 0);
            Matrix toOrigin = new Matrix(1, 0, 0, 1, -(Rectangle.X / 2), -(Rectangle.Y / 2));
            Matrix back = new Matrix(1, 0, 0, 1, Rectangle.X / 2, Rectangle.Y / 2);

            PointF[] points = new PointF[3] {
                new PointF(Rectangle.Left, Rectangle.Top),
                new PointF(Rectangle.Right, Rectangle.Top),
                new PointF(Rectangle.Left, Rectangle.Bottom)
            };

            TransformationMatrix = new Matrix(Rectangle, points);

            TransformationMatrix.Multiply(toOrigin);

            toOrigin.Multiply(rotation);
            toOrigin.Multiply(back);

            grfx.Transform = TransformationMatrix;

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(StrokeColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.Restore(state);
        }
    }
}
