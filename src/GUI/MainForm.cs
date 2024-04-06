using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Draw
{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();

        private bool isLeftMouseButtonDown = false;

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

            if (drawPolygon.Checked)
            {
                // TODO : check if it is selected!
                if (e.Button == MouseButtons.Left)
                {
                    isLeftMouseButtonDown = true;
                }

                if (isLeftMouseButtonDown)
                {
                    statusBar.Items[0].Text = "Последно действие: Поставяне на точка от полигон";
                    dialogProcessor.IsDrawing = true;

                    dialogProcessor.ClickedPoint = e.Location;

                    if (dialogProcessor.PointsList.Count >= 3
                            && dialogProcessor.ContainsPoint(dialogProcessor.ClickedPoint) != null)
                    {
                        drawPolygon_Click(dialogProcessor.ClickedPoint);
                        drawPolygon.Checked = false;
                    }
                    else
                        dialogProcessor.AddPoint();

                    isLeftMouseButtonDown = false;
                    viewPort.Invalidate();
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

            if (!drawPolygon.Checked)
                dialogProcessor.IsDrawing = false;

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

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            //dialogProcessor.AddRandomTriangle();
            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";
            viewPort.Invalidate();
        }

        private void drawPolygon_Click(PointF point)
        {
            dialogProcessor.AddPolygon();

            statusBar.Items[0].Text = "Последно действие: Рисуване на полигон";

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
    }
}
