using Draw.src.Model;
using Draw.src.Processors;
using Draw.src.Processors.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Windows.Forms;
using static Draw.DialogProcessor;

namespace Draw
{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();

        // Проверява дали ляв бутон на мишката е натиснат
        private bool isLeftMouseButtonDown = false;

        // Използва се, за да дефинира тип на сплайн кривата (Безие или Базова сплайн)
        private EnumTypes.SplineType splineType = EnumTypes.SplineType.None;

        public MainForm()
        {
            InitializeComponent();
        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        // --------------------------------------------------------------------------------------------------------------
        #region Mouse Movement
        // --------------------------------------------------------------------------------------------------------------

        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                Shape temp = dialogProcessor.ContainsPoint(e.Location);

                if (temp != null)
                {
                    if (dialogProcessor.Selection.Contains(temp))
                    {
                        statusBar.Items[0].Text = "Последно действие: Деселекция на примитив";

                        var startIndex = dialogProcessor.Selection.IndexOf(temp);

                        dialogProcessor.Selection.Remove(temp);
                    }
                    else
                    {
                        statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                        dialogProcessor.Selection.Add(temp);
                    }

                    selectedShapesLabel.Text = String.Join(" ; ", dialogProcessor.Selection.Select(x => x.Name));

                    viewPort.Invalidate();
                }
                else
                {
                    dialogProcessor.Selection.Clear();
                    viewPort.Invalidate();
                }

                if (dialogProcessor.Selection.Count >= 1)
                {
                    //statusBar.Items[0].Text = "Последно действие: Селекция на примитив";

                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;

                    viewPort.Invalidate();
                }
            }

            if (dialogProcessor.IsDrawing)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftMouseButtonDown = true;
                }

                if (isLeftMouseButtonDown)
                {
                    statusBar.Items[0].Text = "Последно действие: Поставяне на точка";

                    dialogProcessor.ClickedPoint = e.Location;

                    if (PointsList.Count >= 3 &&
                        dialogProcessor.ContainsPoint(dialogProcessor.ClickedPoint) != null)
                    {
                        if (drawPolygon.Checked)
                        {
                            drawPolygon_Click();
                            drawPolygon.Checked = false;
                        }
                        else if (splineType == EnumTypes.SplineType.Bezier)
                        {
                            DrawBezier_Click();
                            splineType = EnumTypes.SplineType.None;
                        }
                        else if (splineType == EnumTypes.SplineType.Base)
                        {
                            DrawSpline_Click();
                            splineType = EnumTypes.SplineType.None;
                        }

                        dialogProcessor.IsDrawing = false;
                    }
                    else
                        dialogProcessor.AddPoint();

                    viewPort.Invalidate();
                    isLeftMouseButtonDown = false;
                }
            }
        }

        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null)
                    statusBar.Items[0].Text = "Последно действие: Влачене";

                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }

            coordinatesBox.Text = $"{e.Location.X}:{e.Location.Y}";
        }

        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;

            isLeftMouseButtonDown = false;
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region Drawing Shapes
        // --------------------------------------------------------------------------------------------------------------

        void DrawRectangleButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        private void drawEllipseButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        private void елипсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawEllipseButton_Click(sender, e);
        }

        private void правиъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawRectangleButtonClick(sender, e);
        }

        private void drawSquare_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomSquare(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

            viewPort.Invalidate();
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomCircle(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на окръжност";

            viewPort.Invalidate();
        }

        private void drawPolygon_Click()
        {
            dialogProcessor.AddPolygon(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на полигон";

            viewPort.Invalidate();
        }

        private void DrawBezier_Click()
        {
            dialogProcessor.AddBezier(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на Безие крива";

            viewPort.Invalidate();
        }

        private void DrawSpline_Click()
        {
            dialogProcessor.AddBSpline(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на Б-Сплайн крива";

            viewPort.Invalidate();
        }

        private void DrawTriangle_Click()
        {
            dialogProcessor.AddRandomTriangle(GetStrokeWidth());

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        private void drawStarBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomStar(GetStrokeWidth());
            viewPort.Invalidate();

            statusBar.Items[0].Text = "Последно действие: Добавяне на звезда";
        }

        private void ромбToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRhomb(GetStrokeWidth());

            viewPort.Invalidate();

            statusBar.Items[0].Text = "Последно действие: Добавяне на ромб";
        }

        private void drawPolygon_Click(object sender, EventArgs e)
        {
            dialogProcessor.IsDrawing = true;
        }

        private void nTagonSidesTextBox_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomNTagon(5);
            viewPort.Invalidate();

            statusBar.Items[0].Text = $"Последно действие: Рисуване на Пентагон";
        }

        private void хексагонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomNTagon(6);
            viewPort.Invalidate();

            statusBar.Items[0].Text = $"Последно действие: Рисуване на Хексагон";
        }

        private void хептагонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomNTagon(7);
            viewPort.Invalidate();

            statusBar.Items[0].Text = $"Последно действие: Рисуване на Хептагон";
        }

        private void сърцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomHeart(GetStrokeWidth());
            viewPort.Invalidate();

            statusBar.Items[0].Text = $"Последно действие: Рисуване на Сърце";
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region DropDown menu items
        // --------------------------------------------------------------------------------------------------------------

        private void кръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCircle_Click(sender, e);
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSquare_Click(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void изтрийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void групиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupShapes();
        }
        private void разгрупиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnGroupShapes();
        }
        private void триъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawTriangle_Click();
        }
        private void уголемиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scale(1.2f);
        }

        private void намалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scale(0.8f);
        }
        private void безиеКриваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splineType = EnumTypes.SplineType.Bezier;
            dialogProcessor.IsDrawing = true;
        }

        private void бСплайнКриваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splineType = EnumTypes.SplineType.Base;
            dialogProcessor.IsDrawing = true;
        }
        private void rotate45_Click(object sender, EventArgs e)
        {
            Rotate(45);
        }

        private void rotate90_Click(object sender, EventArgs e)
        {
            Rotate(90);
        }

        private void rotate180_Click(object sender, EventArgs e)
        {
            Rotate(180);
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region Helper Methods
        // --------------------------------------------------------------------------------------------------------------

        private void GroupShapes()
        {
            dialogProcessor.GroupElements();
            statusBar.Items[0].Text = "Последно действие: Групиране на примитиви";
            viewPort.Invalidate();
        }

        private void UnGroupShapes()
        {
            dialogProcessor.UnGroupElements();
            statusBar.Items[0].Text = "Последно действие: Групиране на примитиви";
            viewPort.Invalidate();
        }

        private void Delete()
        {
            if (dialogProcessor.Selection.Count >= 1)
            {
                statusBar.Items[0].Text = "Последно действие: Изтриване на примитив";

                foreach (var item in dialogProcessor.Selection) // a bit slow, might need some optimizing
                {
                    switch (item.GetType().Name)
                    {
                        case "BezierCurveShape":
                        case "BSplineShape":
                        case "PolygonShape":
                            int index, startIndex;
                            index = startIndex = dialogProcessor.ShapeList.IndexOf(item);
                            int count = 0;

                            while (index < (dialogProcessor.ShapeList.Count - 1) && dialogProcessor.ShapeList[index + 1].GetType().Name == "PointShape")
                            {
                                index++;
                                count++;
                            }

                            dialogProcessor.ShapeList.RemoveRange(startIndex, count + 1);
                            break;

                        default:
                            dialogProcessor.ShapeList.Remove(item);
                            break;
                    }
                }

                dialogProcessor.Selection.Clear();

                viewPort.Invalidate();
            }
        }

        private void Rotate(float rotation)
        {
            dialogProcessor.Rotate(rotation);
            statusBar.Items[0].Text = "Последно действие: Завъртане на примитв/група";
            viewPort.Invalidate();
        }

        private new void Scale(float scaleCoef)
        {
            dialogProcessor.Scale(scaleCoef);

            if (scaleCoef >= 1)
                statusBar.Items[0].Text = "Последно действие: Уголемяване на примитв/група";
            else
                statusBar.Items[0].Text = "Последно действие: Намаляне на примитв/група";

            viewPort.Invalidate();
        }

        private int GetStrokeWidth()
        {
            if (int.TryParse(OutlineTextBox.Text, out int strokeWidth))
                return strokeWidth;

            return 1;
        }

        private int GetOppacity()
        {
            if (int.TryParse(OppacityTextBox.Text, out int oppacity))
                return oppacity;

            return 255;
        }

        private void ScaleUpStrokeWidth()
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                {
                    dialogProcessor.SetStrokeWidth(item.StrokeWidth + 3);
                    OutlineTextBox.Text = $"{item.StrokeWidth}";

                    viewPort.Invalidate();
                }

                statusBar.Items[0].Text = "Последно действие: Задаване на ширина на контур";
            }
        }

        private void ScaleDownStrokeWidth()
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                {
                    dialogProcessor.SetStrokeWidth(item.StrokeWidth - 3);
                    OutlineTextBox.Text = $"{item.StrokeWidth}";

                    viewPort.Invalidate();
                }

                statusBar.Items[0].Text = "Последно действие: Задаване на ширина на контур";
            }
        }

        private void SaveFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;

                if (!fileName.Contains(".json"))
                    fileName += ".json";

                dialogProcessor.SaveToJsonFile(fileName);
            }
        }

        private void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                var loadFromJsonShapes = dialogProcessor.LoadFromJsonFile(fileName);

                dialogProcessor.ShapeList.AddRange(loadFromJsonShapes);
            }
        }

        private void Copy()
        {
            dialogProcessor.Copy();

            statusBar.Items[0].Text = "Последно действие: Копиране";

            viewPort.Invalidate();
        }

        private void Paste()
        {
            dialogProcessor.Paste();

            statusBar.Items[0].Text = "Последно действие: Поставяне";

            viewPort.Invalidate();
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region Coloring and outlines
        // --------------------------------------------------------------------------------------------------------------

        private void FillColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SetFillColor(colorDialog1.Color);

                statusBar.Items[0].Text = "Последно действие: Запълване с цвят ";
                viewPort.Invalidate();
            }
        }
        private void OulineColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SetStrokeColor(colorDialog1.Color);

                viewPort.Invalidate();
                statusBar.Items[0].Text = "Последно действие: Цвят на линия ";
            }
        }

        private void OppacityBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetOpacity(GetOppacity());

            viewPort.Invalidate();

            statusBar.Items[0].Text = "Последно действие: Задаване на прозрачност на фигурата";
        }

        private void удебеляванеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaleUpStrokeWidth();
        }

        private void намалянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaleDownStrokeWidth();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetStrokeWidth(GetStrokeWidth());

            viewPort.Invalidate();

            statusBar.Items[0].Text = "Последно действие: Задаване на ширина на контур";
        }

        private void безцветенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetFillColor(Color.Transparent);
            viewPort.Invalidate();

            statusBar.Items[0].Text = "Последно действие: Безцветен ";
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        // --------------------------------------------------------------------------------------------------------------
        #region Save and Open Methods
        // --------------------------------------------------------------------------------------------------------------

        private void saveModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            statusBar.Items[0].Text = "Последно действие: Запазване";

            viewPort.Invalidate();
        }

        private void openModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
            statusBar.Items[0].Text = "Последно действие: Отваряне";

            viewPort.Invalidate();
        }

        #endregion
        // --------------------------------------------------------------------------------------------------------------

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    Delete();
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip1.Items.Clear();

            if (dialogProcessor.Selection.Count >= 1)
            {
                contextMenuStrip1.Items.Add("Запълни", null, FillColorBtn_Click);
                contextMenuStrip1.Items.Add("Завърти на 45", null, rotate45_Click);
                contextMenuStrip1.Items.Add("Оцвети контур", null, OulineColorBtn_Click);
                contextMenuStrip1.Items.Add("Изтрии", null, DeleteToolStripMenuItem_Click);
            }
            else // for editing selected shape or group
            {
                contextMenuStrip1.Items.Add("Добави правоъгълник", null, DrawRectangleButtonClick);
                contextMenuStrip1.Items.Add("Добави елипса", null, drawEllipseButton_Click);
                contextMenuStrip1.Items.Add("Добави звезда", null, drawStarBtn_Click);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void selectedShapeNameButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SetName(selectedShapeNameTextBox.Text);
            statusBar.Items[0].Text = "Последно действие: Преименуване на примитив/група";

            viewPort.Invalidate();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void селектирайВсичкоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectEverything();
            statusBar.Items[0].Text = "Последно действие: Селектиране на всичко";

            viewPort.Invalidate();
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddExamShape(GetStrokeWidth());
            statusBar.Items[0].Text = "Последно действие: Добавяне на Exam Shape";

            viewPort.Invalidate();
        }
    }
}
