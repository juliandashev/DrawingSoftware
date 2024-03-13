﻿using System;
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

        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);

                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";

                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;

                    viewPort.Invalidate();
                }

            }

            if (drawPolygon.Checked)
            {
                // TODO : check if it is selected!
                dialogProcessor.IsDrawing = true;
            }

            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseButtonDown = true;
            }

            if (dialogProcessor.IsDrawing)
            {
                statusBar.Items[0].Text = "Последно действие: Поставяне на точка от полигон";

                if (isLeftMouseButtonDown)
                {
                    dialogProcessor.ClickedPoint = e.Location;
                    dialogProcessor.AddPoint();

                    dialogProcessor.Selection.Vertices.Add(e.Location);
                    
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

        private void кръгToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCircle_Click(sender, e);
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSquare_Click(sender, e);
        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();
            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";
            viewPort.Invalidate();
        }

        private void drawPolygon_Click(int x, int y)
        {
            dialogProcessor.AddRandomPolygon(x, y);
            statusBar.Items[0].Text = "Последно действие: Рисуване на полигон";
            viewPort.Invalidate();
        }
    }
}
