using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            this.Rectangle = rect;
        }

        public Polygon(Polygon shape) : base(shape)
        {
        }

        #endregion

        #region Properties
        public List<PointShape> Vertices { get; set; } = new List<PointShape>();
        public List<PointF> Points { get; set; } = new List<PointF>();

        public override RectangleF Rectangle
        {
            get => base.Rectangle;
            set => base.Rectangle = value;
        }

        public override PointF Location
        {
            get => base.Location;
            set
            {
                PointF[] transformPointsArray = new PointF[] { value };
                Matrix temp = TransformationMatrix.Clone();
                temp.Invert();
                temp.TransformPoints(transformPointsArray);

                foreach (PointShape shape in Vertices)
                {
                    shape.Location = new PointF(
                        shape.Location.X + transformPointsArray[0].X - base.Location.X,
                        shape.Location.Y + transformPointsArray[0].Y - base.Location.Y
                        );
                }

                base.Location = transformPointsArray[0];
            }
        }

        public override Matrix TransformationMatrix
        {
            get => base.TransformationMatrix;
            set
            {
                base.TransformationMatrix = value;
            }
        }

        public override string Name { get => base.Name; set => base.Name = value; }

        #endregion

        protected int CountIntersections(PointF p, List<PointShape> vertices)
        {
            int count = 0;
            float x1, x2, y1, y2;

            // Lopping through every vertex
            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Обхождане през всеки връх
            for (int i = 0; i < vertices.Count; i++)
            {
                if (i < vertices.Count - 1) // Взимаме всички точки без последната
                {
                    // Definig the x and y of the first point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Дефиниране на х и у на първата точка
                    x1 = vertices[i + 1].Location.X;
                    y1 = vertices[i + 1].Location.Y;

                    // Then definig the x and y of the next point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Същото и за следващата точка
                    x2 = vertices[i].Location.X;
                    y2 = vertices[i].Location.Y;
                }
                else
                {
                    // Finding the values of the last point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Намиране на стойностите на последната точка
                    x1 = vertices[i].Location.X;
                    y1 = vertices[i].Location.Y;

                    // Finding the values of the first point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Намиране на стойностите на първата точка
                    x2 = vertices[0].Location.X;
                    y2 = vertices[0].Location.Y;
                }

                // Two conditions have to be met

                // -------------------------------------------------------------------------------------------------------------------------------------------------
                // 2 условия трябва да бъдат изпълнени

                // First condition ensures that the point is between the two points on the y coordinates of the lines of the polygon

                // -------------------------------------------------------------------------------------------------------------------------------------------------
                // Първото условие ни гарантира, че точката е между 2те точки на по у на линиите на полигона
                bool firstCondition = (p.Y > y2) != (p.Y > y1);

                // Everything is calculated with respect of this coordinate system (with inverted y axis)

                // Second condition's formula is derived from trying to find first x0 = x1 + ?
                // x0 is the intersection of the line of our edge
                // We have to check if point's X coordinate is smaller than x0. This would mean that mouses X coordinate crosses

                // First we know that the length from the origin to the edge we are at is = x2 also known as offset

                // x0 depends on the value of Yp, changeing it changes the value of x0
                // we need to calculate the ratio between the height of our point (yp - y2) and the height of our edge (y1 - y2) this gives a value between [0;1]
                // and then multiplying by the width of the edge (x1 - x2) to see how much x we add to x2

                // and thats how we derived xp = x0 = x2 + ((point.Y - y2) / (y1 - y2)) * (x1 - x2)
                // lastly we take the < sign because we are aiming to be on the left side of the line

                #region Превод

                // Всичко е изчислено спрямо тази координатна система (със завъртян у)

                // Формулата от 2рото условие е получена като при опит да се намери първият х0 = х1 = ?
                // х0 е пресечната точка с линията на нашия връх
                // Сега трябва да проверим дали Х координатата на точката е по-малка от х0. Това ще означава, че Х координатата на мишката пресича линията

                // Първо знаем, че дължината от началото до върхът на който сме в момента е равен на х2

                // х0 зависи от стойността на У на мишката, променяме ли я, се променя и стойността на х0
                // трябва да изчислим пропорцията между височината на нашата точка (yp - y2) и височината на върхът (y1 - y2), който дава стойност между 0 и 1
                // след това умножаваме по ширината на върха (x1 - x2), за да видим колко х трябва да добавим към х2

                // И така стингахме до формулата xp = x0 = x2 + ((point.Y - y2) / (y1 - y2)) * (x1 - x2)
                // Накрая само трябва да вземем < знакът, защото искаме да сме от лявата страна на линията

                #endregion

                bool secondCondition = p.X < x2 + ((p.Y - y2) / (y1 - y2)) * (x1 - x2);

                if (firstCondition && secondCondition)
                    // Then the number of crossed edges increases
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Тогава броят на пресичанията ще се увеличи
                    count++;
            }

            return count;
        }

        protected int CountIntersections(PointF p, List<PointF> points)
        {
            int count = 0;
            float x1, x2, y1, y2;
            // Lopping through every vertex
            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Обхождане през всеки връх
            for (int i = 0; i < points.Count; i++)
            {
                if (i < points.Count - 1) // Взимаме всички точки без последната
                {
                    // Definig the x and y of the first point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Дефиниране на х и у на първата точка
                    x1 = points[i + 1].X;
                    y1 = points[i + 1].Y;

                    // Then definig the x and y of the next point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Същото и за следващата точка
                    x2 = points[i].X;
                    y2 = points[i].Y;
                }
                else
                {
                    // Finding the values of the last point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Намиране на стойностите на последната точка
                    x1 = points[i].X;
                    y1 = points[i].Y;

                    // Finding the values of the first point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Намиране на стойностите на първата точка
                    x2 = points[0].X;
                    y2 = points[0].Y;
                }

                // Two conditions have to be met

                // -------------------------------------------------------------------------------------------------------------------------------------------------
                // 2 условия трябва да бъдат изпълнени

                // First condition ensures that the point is between the two points on the y coordinates of the lines of the polygon

                // -------------------------------------------------------------------------------------------------------------------------------------------------
                // Първото условие ни гарантира, че точката е между 2те точки на по у на линиите на полигона
                bool firstCondition = (p.Y > y2) != (p.Y > y1);

                // Everything is calculated with respect of this coordinate system (with inverted y axis)

                // Second condition's formula is derived from trying to find first x0 = x1 + ?
                // x0 is the intersection of the line of our edge
                // We have to check if point's X coordinate is smaller than x0. This would mean that mouses X coordinate crosses

                // First we know that the length from the origin to the edge we are at is = x2 also known as offset

                // x0 depends on the value of Yp, changeing it changes the value of x0
                // we need to calculate the ratio between the height of our point (yp - y2) and the height of our edge (y1 - y2) this gives a value between [0;1]
                // and then multiplying by the width of the edge (x1 - x2) to see how much x we add to x2

                // and thats how we derived xp = x0 = x2 + ((point.Y - y2) / (y1 - y2)) * (x1 - x2)
                // lastly we take the < sign because we are aiming to be on the left side of the line

                #region Превод

                // Всичко е изчислено спрямо тази координатна система (със завъртян у)

                // Формулата от 2рото условие е получена като при опит да се намери първият х0 = х1 = ?
                // х0 е пресечната точка с линията на нашия връх
                // Сега трябва да проверим дали Х координатата на точката е по-малка от х0. Това ще означава, че Х координатата на мишката пресича линията

                // Първо знаем, че дължината от началото до върхът на който сме в момента е равен на х2

                // х0 зависи от стойността на У на мишката, променяме ли я, се променя и стойността на х0
                // трябва да изчислим пропорцията между височината на нашата точка (yp - y2) и височината на върхът (y1 - y2), който дава стойност между 0 и 1
                // след това умножаваме по ширината на върха (x1 - x2), за да видим колко х трябва да добавим към х2

                // И така стингахме до формулата xp = x0 = x2 + ((point.Y - y2) / (y1 - y2)) * (x1 - x2)
                // Накрая само трябва да вземем < знакът, защото искаме да сме от лявата страна на линията

                #endregion

                bool secondCondition = p.X < x2 + ((p.Y - y2) / (y1 - y2)) * (x1 - x2);

                if (firstCondition && secondCondition)
                    // Then the number of crossed edges increases
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Тогава броят на пресичанията ще се увеличи
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Checks if a point is inside the polygon using Ray Casting.
        /// 
        /// Проверява дали точка е в полигонът, ипозлва се Ray Casting.
        /// </summary>
        /// <param name="point">Mouse (x,y) coordinates</param>
        /// <returns></returns>

        // Doesn't matter if it's convex or not.
        // Works O(n) where n is the Vertices Count

        // Няма значение дали е вдлъбнат или изпъкнал
        // Работи О(n) където n е броят на върговете
        public override bool Contains(PointF point)
        {
            // Записва точката която проверяваме дали е в полигона в масив
            PointF[] transformPointsArray = new PointF[] { point };

            // Правим временна матрица на която присвояваме стойността на нашата матрица на Трансофрмация
            Matrix temp = TransformationMatrix.Clone();

            // Инвертираме, за да се върнем обратно в координатната система използвана от програмата
            temp.Invert();

            // Връщаме се в координатната система спомената горе
            temp.TransformPoints(transformPointsArray);
            PointF p = transformPointsArray[0]; // за по-малко писане 

            // Ако има фигури от тип PointShape в списъка, ще изчисляваме точката дали е в полигона спрямо тези фигури
            if (Vertices.Count >= 1)
                return CountIntersections(p, Vertices) % 2 == 1; // Брои колко пъти е пресечена стена

            // Ако няма ще изчисляваме точката в полигона спрямо зададени точки
            return CountIntersections(p, Points) % 2 == 1;

            // Проверява се за нечетно число, защото нечетният брои пресичания на стена означава, че точката лежи вътре в пшолигона
        }
    }
}
