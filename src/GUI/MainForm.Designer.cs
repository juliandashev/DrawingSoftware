﻿namespace Draw
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
            this.полигонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безиеКриваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бСплайнКриваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.триъгълникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.манипулацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаКонтурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безцветенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтрийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завъртиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наПримитивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90Primitive = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180Primitive = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270Primitive = new System.Windows.Forms.ToolStripMenuItem();
            this.наГрупаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate90Group = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate180Group = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate270Group = new System.Windows.Forms.ToolStripMenuItem();
            this.групиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.coordinatesBox = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripLabel();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawSquare = new System.Windows.Forms.ToolStripButton();
            this.drawCircle = new System.Windows.Forms.ToolStripButton();
            this.drawPolygon = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.FillColorBtn = new System.Windows.Forms.ToolStripButton();
            this.OulineColorBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.OppacityTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripLabel();
            this.OutlineTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.цвятНаЗапълванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаКонтурToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.намалиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.разгрупиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.IndianRed;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.фигуриToolStripMenuItem,
            this.editToolStripMenuItem,
            this.манипулацииToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(125, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(568, 24);
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
            this.кръгToolStripMenuItem,
            this.полигонToolStripMenuItem,
            this.сплайнToolStripMenuItem,
            this.триъгълникToolStripMenuItem});
            this.фигуриToolStripMenuItem.Name = "фигуриToolStripMenuItem";
            this.фигуриToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.фигуриToolStripMenuItem.Text = "Фигури";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
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
            this.кръгToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.кръгToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.кръгToolStripMenuItem.Text = "Кръг";
            this.кръгToolStripMenuItem.Click += new System.EventHandler(this.кръгToolStripMenuItem_Click);
            // 
            // полигонToolStripMenuItem
            // 
            this.полигонToolStripMenuItem.Name = "полигонToolStripMenuItem";
            this.полигонToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.полигонToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.полигонToolStripMenuItem.Text = "Полигон";
            // 
            // сплайнToolStripMenuItem
            // 
            this.сплайнToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безиеКриваToolStripMenuItem,
            this.бСплайнКриваToolStripMenuItem});
            this.сплайнToolStripMenuItem.Name = "сплайнToolStripMenuItem";
            this.сплайнToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сплайнToolStripMenuItem.Text = "Сплайн";
            // 
            // безиеКриваToolStripMenuItem
            // 
            this.безиеКриваToolStripMenuItem.Name = "безиеКриваToolStripMenuItem";
            this.безиеКриваToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.безиеКриваToolStripMenuItem.Text = "Безие Крива";
            this.безиеКриваToolStripMenuItem.Click += new System.EventHandler(this.безиеКриваToolStripMenuItem_Click);
            // 
            // бСплайнКриваToolStripMenuItem
            // 
            this.бСплайнКриваToolStripMenuItem.Name = "бСплайнКриваToolStripMenuItem";
            this.бСплайнКриваToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.бСплайнКриваToolStripMenuItem.Text = "Б-Сплайн Крива";
            this.бСплайнКриваToolStripMenuItem.Click += new System.EventHandler(this.бСплайнКриваToolStripMenuItem_Click);
            // 
            // триъгълникToolStripMenuItem
            // 
            this.триъгълникToolStripMenuItem.Name = "триъгълникToolStripMenuItem";
            this.триъгълникToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.триъгълникToolStripMenuItem.Text = "Триъгълник";
            this.триъгълникToolStripMenuItem.Click += new System.EventHandler(this.триъгълникToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // манипулацииToolStripMenuItem
            // 
            this.манипулацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цвятНаЗапълванеToolStripMenuItem,
            this.цвятНаКонтурToolStripMenuItem,
            this.безцветенToolStripMenuItem,
            this.уголемиToolStripMenuItem,
            this.намалиToolStripMenuItem,
            this.изтрийToolStripMenuItem1,
            this.завъртиToolStripMenuItem,
            this.групиранеToolStripMenuItem,
            this.разгрупиранеToolStripMenuItem});
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
            this.уголемиToolStripMenuItem.Click += new System.EventHandler(this.уголемиToolStripMenuItem_Click);
            // 
            // намалиToolStripMenuItem
            // 
            this.намалиToolStripMenuItem.Name = "намалиToolStripMenuItem";
            this.намалиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.намалиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.намалиToolStripMenuItem.Text = "Намали";
            this.намалиToolStripMenuItem.Click += new System.EventHandler(this.намалиToolStripMenuItem_Click);
            // 
            // изтрийToolStripMenuItem1
            // 
            this.изтрийToolStripMenuItem1.Name = "изтрийToolStripMenuItem1";
            this.изтрийToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.изтрийToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.изтрийToolStripMenuItem1.Text = "Изтрий";
            this.изтрийToolStripMenuItem1.Click += new System.EventHandler(this.изтрийToolStripMenuItem1_Click);
            // 
            // завъртиToolStripMenuItem
            // 
            this.завъртиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наПримитивToolStripMenuItem,
            this.наГрупаToolStripMenuItem});
            this.завъртиToolStripMenuItem.Name = "завъртиToolStripMenuItem";
            this.завъртиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.завъртиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.завъртиToolStripMenuItem.Text = "Завъртане";
            // 
            // наПримитивToolStripMenuItem
            // 
            this.наПримитивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90Primitive,
            this.Rotate180Primitive,
            this.Rotate270Primitive});
            this.наПримитивToolStripMenuItem.Name = "наПримитивToolStripMenuItem";
            this.наПримитивToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.наПримитивToolStripMenuItem.Text = "На Примитив";
            // 
            // Rotate90Primitive
            // 
            this.Rotate90Primitive.Name = "Rotate90Primitive";
            this.Rotate90Primitive.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.NumPad1)));
            this.Rotate90Primitive.Size = new System.Drawing.Size(207, 22);
            this.Rotate90Primitive.Text = "90°";
            this.Rotate90Primitive.Click += new System.EventHandler(this.Rotate90Primitive_Click);
            // 
            // Rotate180Primitive
            // 
            this.Rotate180Primitive.Name = "Rotate180Primitive";
            this.Rotate180Primitive.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.NumPad2)));
            this.Rotate180Primitive.Size = new System.Drawing.Size(207, 22);
            this.Rotate180Primitive.Text = "180°";
            this.Rotate180Primitive.Click += new System.EventHandler(this.Rotate180Primitive_Click);
            // 
            // Rotate270Primitive
            // 
            this.Rotate270Primitive.Name = "Rotate270Primitive";
            this.Rotate270Primitive.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.NumPad3)));
            this.Rotate270Primitive.Size = new System.Drawing.Size(207, 22);
            this.Rotate270Primitive.Text = "270°";
            this.Rotate270Primitive.Click += new System.EventHandler(this.Rotate270Primitive_Click);
            // 
            // наГрупаToolStripMenuItem
            // 
            this.наГрупаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rotate90Group,
            this.Rotate180Group,
            this.Rotate270Group});
            this.наГрупаToolStripMenuItem.Name = "наГрупаToolStripMenuItem";
            this.наГрупаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.наГрупаToolStripMenuItem.Text = "На Група";
            // 
            // Rotate90Group
            // 
            this.Rotate90Group.Name = "Rotate90Group";
            this.Rotate90Group.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.NumPad1)));
            this.Rotate90Group.Size = new System.Drawing.Size(216, 22);
            this.Rotate90Group.Text = "90°";
            this.Rotate90Group.Click += new System.EventHandler(this.Rotate90Group_Click);
            // 
            // Rotate180Group
            // 
            this.Rotate180Group.Name = "Rotate180Group";
            this.Rotate180Group.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.NumPad2)));
            this.Rotate180Group.Size = new System.Drawing.Size(216, 22);
            this.Rotate180Group.Text = "180°";
            this.Rotate180Group.Click += new System.EventHandler(this.Rotate180Group_Click);
            // 
            // Rotate270Group
            // 
            this.Rotate270Group.Name = "Rotate270Group";
            this.Rotate270Group.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.NumPad3)));
            this.Rotate270Group.Size = new System.Drawing.Size(216, 22);
            this.Rotate270Group.Text = "270°";
            this.Rotate270Group.Click += new System.EventHandler(this.Rotate270Group_Click);
            // 
            // групиранеToolStripMenuItem
            // 
            this.групиранеToolStripMenuItem.Name = "групиранеToolStripMenuItem";
            this.групиранеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.групиранеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.групиранеToolStripMenuItem.Text = "Групиране";
            this.групиранеToolStripMenuItem.Click += new System.EventHandler(this.групиранеToolStripMenuItem_Click);
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
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Beige;
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
            this.coordinatesBox.ActiveLinkColor = System.Drawing.Color.Black;
            this.coordinatesBox.BackColor = System.Drawing.Color.Transparent;
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
            this.speedMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.toolStripButton3,
            this.drawRectangleSpeedButton,
            this.drawEllipseButton,
            this.drawSquare,
            this.drawCircle,
            this.drawPolygon,
            this.DeleteBtn,
            this.FillColorBtn,
            this.OulineColorBtn,
            this.toolStripButton1,
            this.OppacityTextBox,
            this.toolStripButton2,
            this.OutlineTextBox});
            this.speedMenu.Location = new System.Drawing.Point(0, 0);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.speedMenu.Size = new System.Drawing.Size(125, 401);
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
            this.pickUpSpeedButton.Size = new System.Drawing.Size(122, 24);
            this.pickUpSpeedButton.Text = "Cursor";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(122, 15);
            this.toolStripButton3.Text = "Фигури:";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(122, 24);
            this.drawRectangleSpeedButton.Text = "Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleButtonClick);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(122, 24);
            this.drawEllipseButton.Text = "drawEllipseButton";
            this.drawEllipseButton.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // drawSquare
            // 
            this.drawSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquare.Image = ((System.Drawing.Image)(resources.GetObject("drawSquare.Image")));
            this.drawSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquare.Name = "drawSquare";
            this.drawSquare.Size = new System.Drawing.Size(122, 24);
            this.drawSquare.Text = "drawSquare";
            this.drawSquare.Click += new System.EventHandler(this.drawSquare_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircle.Image = ((System.Drawing.Image)(resources.GetObject("drawCircle.Image")));
            this.drawCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(122, 24);
            this.drawCircle.Text = "drawCircle";
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // drawPolygon
            // 
            this.drawPolygon.CheckOnClick = true;
            this.drawPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(122, 4);
            this.drawPolygon.Text = "drawPolygon";
            this.drawPolygon.Click += new System.EventHandler(this.drawPolygon_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 4);
            this.DeleteBtn.Text = "DeleteBtn";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FillColorBtn
            // 
            this.FillColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("FillColorBtn.Image")));
            this.FillColorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FillColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorBtn.Name = "FillColorBtn";
            this.FillColorBtn.Size = new System.Drawing.Size(122, 24);
            this.FillColorBtn.Text = "Запълване:";
            this.FillColorBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.FillColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FillColorBtn.Click += new System.EventHandler(this.FillColorBtn_Click);
            this.FillColorBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            // 
            // OulineColorBtn
            // 
            this.OulineColorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OulineColorBtn.BackgroundImage")));
            this.OulineColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("OulineColorBtn.Image")));
            this.OulineColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OulineColorBtn.Name = "OulineColorBtn";
            this.OulineColorBtn.Size = new System.Drawing.Size(122, 24);
            this.OulineColorBtn.Text = "Цвят на контур:";
            this.OulineColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OulineColorBtn.Click += new System.EventHandler(this.OulineColorBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(122, 19);
            this.toolStripButton1.Text = "Прозрачност:";
            // 
            // OppacityTextBox
            // 
            this.OppacityTextBox.AcceptsReturn = true;
            this.OppacityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OppacityTextBox.Name = "OppacityTextBox";
            this.OppacityTextBox.Size = new System.Drawing.Size(120, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(122, 15);
            this.toolStripButton2.Text = "Размер на контур:";
            // 
            // OutlineTextBox
            // 
            this.OutlineTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OutlineTextBox.Name = "OutlineTextBox";
            this.OutlineTextBox.Size = new System.Drawing.Size(120, 23);
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
            this.DeleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
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
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.DeleteToolStripMenuItem.Text = "Изтрий";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // viewPort
            // 
            this.viewPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPort.ContextMenuStrip = this.contextMenuStrip1;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewPort.Location = new System.Drawing.Point(125, 24);
            this.viewPort.Margin = new System.Windows.Forms.Padding(4);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(568, 377);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // разгрупиранеToolStripMenuItem
            // 
            this.разгрупиранеToolStripMenuItem.Name = "разгрупиранеToolStripMenuItem";
            this.разгрупиранеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.разгрупиранеToolStripMenuItem.Text = "Разгрупиране";
            this.разгрупиранеToolStripMenuItem.Click += new System.EventHandler(this.разгрупиранеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(693, 423);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
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
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтрийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawSquare;
        private System.Windows.Forms.ToolStripButton drawCircle;
        private System.Windows.Forms.ToolStripStatusLabel coordinatesBox;
        private System.Windows.Forms.ToolStripMenuItem завъртиToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton drawPolygon;
        private System.Windows.Forms.ToolStripButton FillColorBtn;
        private System.Windows.Forms.ToolStripMenuItem полигонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наПримитивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotate90Primitive;
        private System.Windows.Forms.ToolStripMenuItem Rotate180Primitive;
        private System.Windows.Forms.ToolStripMenuItem Rotate270Primitive;
        private System.Windows.Forms.ToolStripMenuItem наГрупаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rotate90Group;
        private System.Windows.Forms.ToolStripMenuItem Rotate180Group;
        private System.Windows.Forms.ToolStripMenuItem Rotate270Group;
        private System.Windows.Forms.ToolStripMenuItem групиранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безиеКриваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бСплайнКриваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem триъгълникToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox OppacityTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox OutlineTextBox;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripLabel toolStripButton3;
        private System.Windows.Forms.ToolStripButton OulineColorBtn;
        private System.Windows.Forms.ToolStripMenuItem разгрупиранеToolStripMenuItem;
    }
}
