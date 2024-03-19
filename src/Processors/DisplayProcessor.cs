using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Draw.src.Model;

namespace Draw
{
    public class DisplayProcessor
    {
        #region Constructor

        public DisplayProcessor()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Списък с всички елементи формиращи изображението.
        /// </summary>
        private List<Shape> shapeList = new List<Shape>();
        public List<Shape> ShapeList
        {
            get { return shapeList; }
            set { shapeList = value; }
        }

        private List<Polygon> polygonList = new List<Polygon>();
        public List<Polygon> PolygonList
        {
            get { return polygonList; }
            set { polygonList = value; }
        }

        #endregion

        #region Drawing

        /// <summary>
        /// Прерисува всички елементи в shapeList върху e.Graphics
        /// </summary>
        public void ReDraw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Draw(e.Graphics);
        }

        /// <summary>
        /// Визуализация.
        /// Обхождане на всички елементи в списъка и извикване на визуализиращия им метод.
        /// </summary>
        /// <param name="grfx">Къде да се извърши визуализацията.</param>
        public virtual void Draw(Graphics grfx)
        {
            foreach (Shape item in ShapeList)
            {
                DrawShape(grfx, item);
            }

            foreach (Polygon item in PolygonList)
            {
                DrawShape(grfx, item);
            }
        }

        /// <summary>
        /// Визуализира даден елемент от изображението.
        /// </summary>
        /// <param name="grfx">Къде да се извърши визуализацията.</param>
        /// <param name="item">Елемент за визуализиране.</param>
        public virtual void DrawShape(Graphics grfx, Shape item)
        {
            if (item.RotationAngle != 0)
                item.DrawSelf(grfx, item.RotationAngle);
            else
                item.DrawSelf(grfx);
        }

        public virtual void DrawShape(Graphics grfx, Polygon item)
        {
            item.DrawSelf(grfx);
        }

        #endregion
    }
}
