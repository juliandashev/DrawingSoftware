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
                foreach (PointShape shape in Vertices)
                {
                    shape.Location = new PointF(
                        shape.Location.X + value.X - base.Location.X,
                        shape.Location.Y + value.Y - base.Location.Y
                        );
                }

                base.Location = value;
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

        #endregion

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

            // Variable for counting how many walls were intersected
            // Променлива, която ще брои колко стени са пресечени
            int count = 0;

            float x1, y1, x2, y2;

            // Lopping through every vertex
            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Обхождане през всеки връх
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (i < Vertices.Count - 1) // Взимаме всички точки без последната
                {
                    // Definig the x and y of the first point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Дефиниране на х и у на първата точка
                    x1 = Vertices[i + 1].Location.X;
                    y1 = Vertices[i + 1].Location.Y;

                    // Then definig the x and y of the next point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Същото и за следващата точка
                    x2 = Vertices[i].Location.X;
                    y2 = Vertices[i].Location.Y;
                }
                else
                {
                    // Finding the values of the last point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Намиране на стойностите на последната точка
                    x1 = Vertices[i].Location.X;
                    y1 = Vertices[i].Location.Y;

                    // Finding the values of the first point
                    // -------------------------------------------------------------------------------------------------------------------------------------------------
                    // Намиране на стойностите на първата точка
                    x2 = Vertices[0].Location.X;
                    y2 = Vertices[0].Location.Y;
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

            // Return true if its an odd number and false if its an even
            // odd meaning - inside the polygon
            // even meaning - outside the polygon

            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // Връща се true ако е нечечтно число и false ако е четно
            // нечетно означава, че точката е в полигонът
            // четно означава, че точката не е в полигонът
            return count % 2 == 1;
        }
    }
}
