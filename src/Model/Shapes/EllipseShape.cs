using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class EllipseShape : Shape
    {
        #region Constructor

        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(EllipseShape shape) : base(shape)
        {
        }

        #endregion

        // Cool thing is that this could be used for the circle primitive as well 
        // -------------------------------------------------------------------------------------------------------------------------------------------------
        // Може да бъде използвано и за кръг, не само за елипса
        public override bool Contains(PointF point)
        {
            PointF[] transformPointsArray = new PointF[] { point };
            Matrix temp = TransformationMatrix.Clone();

            temp.Invert();
            temp.TransformPoints(transformPointsArray);

            // calculating the half width and half height of the Rectangle
            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Изчисляване на половината ширина и височина
            float halfWidth = Rectangle.Width / 2;
            float halfHeight = Rectangle.Height / 2;

            // Find the center of the ellipse using the Rectangle.Left prop
            // by getting the left edge and addding the halfwidth we are getting the x coordinate of the center
            // similliar thing applies to the y coordinate

            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Намиране центъра на елипсвата като използваме Rectangle.Left пропърти
            // Като вземем левият край и добавим полуширината ще получим х координатата на цантъра
            // Аналогично и за у координатата
            PointF ellipseCenter = new PointF(
                Rectangle.Left + halfWidth,
                Rectangle.Top + halfHeight);

            // basically returning the formula
            // ((x-h) / rx)^2 + ((y-k) / ry)^2 <= 1
            // where < 1 is inside the ellipse and = 1 means on the line

            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Формулата е:
            // ((x-h) / rx)^2 + ((y-k) / ry)^2 <= 1
            // Където х и у са точките на мишката
            // h и k са координатите на центъра на елипсата
            // rx и ry са половината ширина и височина
            // Ако за урванението е изпълнено, че е по-малко от 1, значи точката е в елипсата,
            // ако е = на 1,
            // следва че лежи на линията, ако е по-голямо е извън елипсата
            return
                Math.Pow((transformPointsArray[0].X - ellipseCenter.X) / halfWidth, 2) +
                Math.Pow((transformPointsArray[0].Y - ellipseCenter.Y) / halfHeight, 2) 
                    <= 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            State = grfx.Save();

            base.DrawSelf(grfx);

            grfx.Transform = TransformationMatrix;

            FillColor = Color.FromArgb(Opacity, FillColor);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(StrokeColor, StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.Restore(State);
        }
    }
}
