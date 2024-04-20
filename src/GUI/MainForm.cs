using Draw.src.Model;
using Draw.src.Processors;
using Draw.src.Processors.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Draw.DialogProcessor;

namespace Draw
{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();

        private bool isLeftMouseButtonDown = false;

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

        #region Mouse Movement
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
                        dialogProcessor.Selection.Remove(temp);
                    }
                    else
                    {
                        statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                        dialogProcessor.Selection.Add(temp);
                    }

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

                    if (DialogProcessor.PointsList.Count >= 3)
                    {
                        if (dialogProcessor.ContainsPoint(dialogProcessor.ClickedPoint) != null)
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
                        }
                        else if (DialogProcessor.PointsList.Count == 3)
                        {
                            DrawTriangle_Click();
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

        #region Drawing Shapes
        void DrawRectangleButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        private void drawEllipseButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse();

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
            dialogProcessor.AddRandomSquare();

            statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

            viewPort.Invalidate();
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomCircle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на окръжност";

            viewPort.Invalidate();
        }

        private void drawPolygon_Click()
        {
            dialogProcessor.AddPolygon();

            statusBar.Items[0].Text = "Последно действие: Рисуване на полигон";

            viewPort.Invalidate();
        }

        private void DrawBezier_Click()
        {
            dialogProcessor.AddBezier();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Безие крива";

            viewPort.Invalidate();
        }

        private void DrawSpline_Click()
        {
            dialogProcessor.AddBSpline();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Б-Сплайн крива";

            viewPort.Invalidate();
        }

        private void DrawTriangle_Click()
        {
            dialogProcessor.AddTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        #endregion

        #region DropDown menu items

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

        private void Rotate90Primitive_Click(object sender, EventArgs e)
        {
            RotateShape(90);
        }

        private void Rotate180Primitive_Click(object sender, EventArgs e)
        {
            RotateShape(180);
        }

        private void Rotate270Primitive_Click(object sender, EventArgs e)
        {
            RotateShape(270);
        }

        private void Rotate90Group_Click(object sender, EventArgs e)
        {
            RotateGroup(90);
        }

        private void Rotate180Group_Click(object sender, EventArgs e)
        {
            RotateGroup(180);
        }

        private void Rotate270Group_Click(object sender, EventArgs e)
        {
            RotateGroup(270);
        }
        private void групиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupShapes();
        }

        #endregion

        #region Helper Methods

        private void RotateShape(float rotation)
        {
            dialogProcessor.RotateShape(rotation);
            statusBar.Items[0].Text = "Последно действие: Завъртане на фигура";
            viewPort.Invalidate();
        }

        private void RotateGroup(float rotation)
        {
            dialogProcessor.RotateGroup(rotation);
            statusBar.Items[0].Text = "Последно действие: Завъртане на група";
            viewPort.Invalidate();
        }

        private void ScaleShape(float scaleX, float scaleY)
        {
            dialogProcessor.ScaleShape(scaleX, scaleY);
            statusBar.Items[0].Text = "Последно действие: Завъртане на фигура";
            viewPort.Invalidate();
        }

        private void ScaleGroup(float scaleX, float scaleY)
        {
            dialogProcessor.ScaleGroup(scaleX, scaleY);
            statusBar.Items[0].Text = "Последно действие: Завъртане на група";
            viewPort.Invalidate();
        }

        private void GroupShapes()
        {
            dialogProcessor.GroupElements();
            statusBar.Items[0].Text = "Последно действие: Групиране на примитиви";
            viewPort.Invalidate();
        }

        private void Delete()
        {
            if (dialogProcessor.Selection.Count >= 1)
            {
                statusBar.Items[0].Text = "Последно действие: Изтриване на примитив";

                foreach (var item in dialogProcessor.Selection)
                {
                    dialogProcessor.ShapeList.Remove(item);
                }

                dialogProcessor.Selection.Clear();

                viewPort.Invalidate();
            }
        }

        #endregion

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip1.Items.Clear();

            if (dialogProcessor.Selection.Count >= 1)
            {
                contextMenuStrip1.Items.Add("Color", null, ColorBtn_Click);
                contextMenuStrip1.Items.Add("Delete", null, DeleteToolStripMenuItem_Click);
            }
            else // for editing selected shape or group
                contextMenuStrip1.Items.Add("Add Rectangle", null, DrawRectangleButtonClick);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            // TODO: Color stuff
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

        private void drawPolygon_Click(object sender, EventArgs e)
        {
            dialogProcessor.IsDrawing = true;
        }

        private void триъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.IsDrawing = true;
        }
    }
}
