namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигуриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.елипсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правиъгълникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кръгToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.манипулацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаКонтурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безцветенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтрийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordinatesBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawSquare = new System.Windows.Forms.ToolStripButton();
            this.drawCircle = new System.Windows.Forms.ToolStripButton();
            this.DrawTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.цвятНаЗапълванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаКонтурToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.намалиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изтрийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.drawPolygon = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.фигуриToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.манипулацииToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(693, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveModelToolStripMenuItem,
            this.openModelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveModelToolStripMenuItem
            // 
            this.saveModelToolStripMenuItem.Name = "saveModelToolStripMenuItem";
            this.saveModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveModelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveModelToolStripMenuItem.Text = "Save Model";
            // 
            // openModelToolStripMenuItem
            // 
            this.openModelToolStripMenuItem.Name = "openModelToolStripMenuItem";
            this.openModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openModelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openModelToolStripMenuItem.Text = "Open Model";
            // 
            // фигуриToolStripMenuItem
            // 
            this.фигуриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem,
            this.елипсаToolStripMenuItem,
            this.правиъгълникToolStripMenuItem,
            this.кръгToolStripMenuItem});
            this.фигуриToolStripMenuItem.Name = "фигуриToolStripMenuItem";
            this.фигуриToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.фигуриToolStripMenuItem.Text = "Фигури";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // елипсаToolStripMenuItem
            // 
            this.елипсаToolStripMenuItem.Name = "елипсаToolStripMenuItem";
            this.елипсаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.елипсаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.елипсаToolStripMenuItem.Text = "Елипса";
            this.елипсаToolStripMenuItem.Click += new System.EventHandler(this.елипсаToolStripMenuItem_Click);
            // 
            // правиъгълникToolStripMenuItem
            // 
            this.правиъгълникToolStripMenuItem.Name = "правиъгълникToolStripMenuItem";
            this.правиъгълникToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.правиъгълникToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.правиъгълникToolStripMenuItem.Text = "Правоъгълник";
            this.правиъгълникToolStripMenuItem.Click += new System.EventHandler(this.правиъгълникToolStripMenuItem_Click);
            // 
            // кръгToolStripMenuItem
            // 
            this.кръгToolStripMenuItem.Name = "кръгToolStripMenuItem";
            this.кръгToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.кръгToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.кръгToolStripMenuItem.Text = "Кръг";
            this.кръгToolStripMenuItem.Click += new System.EventHandler(this.кръгToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // манипулацииToolStripMenuItem
            // 
            this.манипулацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цвятНаЗапълванеToolStripMenuItem,
            this.цвятНаКонтурToolStripMenuItem,
            this.безцветенToolStripMenuItem,
            this.уголемиToolStripMenuItem,
            this.намалиToolStripMenuItem,
            this.изтрийToolStripMenuItem1});
            this.манипулацииToolStripMenuItem.Name = "манипулацииToolStripMenuItem";
            this.манипулацииToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.манипулацииToolStripMenuItem.Text = "Манипулации";
            // 
            // цвятНаЗапълванеToolStripMenuItem
            // 
            this.цвятНаЗапълванеToolStripMenuItem.Name = "цвятНаЗапълванеToolStripMenuItem";
            this.цвятНаЗапълванеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.цвятНаЗапълванеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.цвятНаЗапълванеToolStripMenuItem.Text = "Цвят на запълване";
            // 
            // цвятНаКонтурToolStripMenuItem
            // 
            this.цвятНаКонтурToolStripMenuItem.Name = "цвятНаКонтурToolStripMenuItem";
            this.цвятНаКонтурToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.цвятНаКонтурToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.цвятНаКонтурToolStripMenuItem.Text = "Цвят на контур";
            // 
            // безцветенToolStripMenuItem
            // 
            this.безцветенToolStripMenuItem.Name = "безцветенToolStripMenuItem";
            this.безцветенToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.безцветенToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.безцветенToolStripMenuItem.Text = "Безцветен";
            // 
            // уголемиToolStripMenuItem
            // 
            this.уголемиToolStripMenuItem.Name = "уголемиToolStripMenuItem";
            this.уголемиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.уголемиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.уголемиToolStripMenuItem.Text = "Уголеми";
            // 
            // намалиToolStripMenuItem
            // 
            this.намалиToolStripMenuItem.Name = "намалиToolStripMenuItem";
            this.намалиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.намалиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.намалиToolStripMenuItem.Text = "Намали";
            // 
            // изтрийToolStripMenuItem1
            // 
            this.изтрийToolStripMenuItem1.Name = "изтрийToolStripMenuItem1";
            this.изтрийToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.изтрийToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.изтрийToolStripMenuItem1.Text = "Изтрий";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.LightCoral;
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel,
            this.coordinatesBox});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(693, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // coordinatesBox
            // 
            this.coordinatesBox.BackColor = System.Drawing.Color.Firebrick;
            this.coordinatesBox.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.coordinatesBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.coordinatesBox.ForeColor = System.Drawing.Color.Black;
            this.coordinatesBox.Name = "coordinatesBox";
            this.coordinatesBox.Size = new System.Drawing.Size(46, 17);
            this.coordinatesBox.Text = "cordTxt";
            // 
            // speedMenu
            // 
            this.speedMenu.BackColor = System.Drawing.Color.IndianRed;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.drawRectangleSpeedButton,
            this.drawEllipseButton,
            this.drawSquare,
            this.drawCircle,
            this.DrawTriangleButton,
            this.drawPolygon});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(693, 27);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(24, 24);
            this.pickUpSpeedButton.Text = "Cursor";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(24, 24);
            this.drawRectangleSpeedButton.Text = "Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleButtonClick);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(24, 24);
            this.drawEllipseButton.Text = "drawEllipseButton";
            this.drawEllipseButton.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // drawSquare
            // 
            this.drawSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquare.Image = ((System.Drawing.Image)(resources.GetObject("drawSquare.Image")));
            this.drawSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquare.Name = "drawSquare";
            this.drawSquare.Size = new System.Drawing.Size(24, 24);
            this.drawSquare.Text = "drawSquare";
            this.drawSquare.Click += new System.EventHandler(this.drawSquare_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircle.Image = ((System.Drawing.Image)(resources.GetObject("drawCircle.Image")));
            this.drawCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(24, 24);
            this.drawCircle.Text = "drawCircle";
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // DrawTriangleButton
            // 
            this.DrawTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawTriangleButton.Image")));
            this.DrawTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawTriangleButton.Name = "DrawTriangleButton";
            this.DrawTriangleButton.Size = new System.Drawing.Size(24, 24);
            this.DrawTriangleButton.Text = "DrawTriangleButton";
            this.DrawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цвятНаЗапълванеToolStripMenuItem1,
            this.цвятНаКонтурToolStripMenuItem1,
            this.уголемиToolStripMenuItem1,
            this.намалиToolStripMenuItem1,
            this.изтрийToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 114);
            // 
            // цвятНаЗапълванеToolStripMenuItem1
            // 
            this.цвятНаЗапълванеToolStripMenuItem1.Name = "цвятНаЗапълванеToolStripMenuItem1";
            this.цвятНаЗапълванеToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.цвятНаЗапълванеToolStripMenuItem1.Text = "Цвят на запълване";
            // 
            // цвятНаКонтурToolStripMenuItem1
            // 
            this.цвятНаКонтурToolStripMenuItem1.Name = "цвятНаКонтурToolStripMenuItem1";
            this.цвятНаКонтурToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.цвятНаКонтурToolStripMenuItem1.Text = "Цвят на контур";
            // 
            // уголемиToolStripMenuItem1
            // 
            this.уголемиToolStripMenuItem1.Name = "уголемиToolStripMenuItem1";
            this.уголемиToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.уголемиToolStripMenuItem1.Text = "Уголеми";
            // 
            // намалиToolStripMenuItem1
            // 
            this.намалиToolStripMenuItem1.Name = "намалиToolStripMenuItem1";
            this.намалиToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.намалиToolStripMenuItem1.Text = "Намали ";
            // 
            // изтрийToolStripMenuItem
            // 
            this.изтрийToolStripMenuItem.Name = "изтрийToolStripMenuItem";
            this.изтрийToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.изтрийToolStripMenuItem.Text = "Изтрий";
            // 
            // viewPort
            // 
            this.viewPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPort.ContextMenuStrip = this.contextMenuStrip1;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 51);
            this.viewPort.Margin = new System.Windows.Forms.Padding(4);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(693, 372);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // drawPolygon
            // 
            this.drawPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygon.Image = ((System.Drawing.Image)(resources.GetObject("drawPolygon.Image")));
            this.drawPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(24, 24);
            this.drawPolygon.Text = "drawPolygon";
            this.drawPolygon.Click += new System.EventHandler(this.drawPolygon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem фигуриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem елипсаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правиъгълникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кръгToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem манипулацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвятНаЗапълванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвятНаКонтурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безцветенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уголемиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвятНаЗапълванеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цвятНаКонтурToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уголемиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem намалиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изтрийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтрийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawSquare;
        private System.Windows.Forms.ToolStripButton drawCircle;
        private System.Windows.Forms.ToolStripStatusLabel coordinatesBox;
        private System.Windows.Forms.ToolStripButton DrawTriangleButton;
        private System.Windows.Forms.ToolStripButton drawPolygon;
    }
}
