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
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
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
            this.ромбToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нтагонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nTagonSidesTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.хексагонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хептагонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.манипулацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаЗапълванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвятНаКонтурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безцветенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уголемиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтрийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завъртиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate45 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate90 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.групиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разгрупиранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удебеляванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.намалянеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.drawStarBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
            this.FillColorBtn = new System.Windows.Forms.ToolStripButton();
            this.OulineColorBtn = new System.Windows.Forms.ToolStripButton();
            this.OppacityBtn = new System.Windows.Forms.ToolStripButton();
            this.OppacityTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.OutlineBtn = new System.Windows.Forms.ToolStripButton();
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
            this.преименувайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(115, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            toolStripSeparator3.Size = new System.Drawing.Size(115, 6);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.IndianRed;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.фигуриToolStripMenuItem,
            this.манипулацииToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(118, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1268, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveModelToolStripMenuItem
            // 
            this.saveModelToolStripMenuItem.Name = "saveModelToolStripMenuItem";
            this.saveModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveModelToolStripMenuItem.Text = "Save Model";
            // 
            // openModelToolStripMenuItem
            // 
            this.openModelToolStripMenuItem.Name = "openModelToolStripMenuItem";
            this.openModelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.триъгълникToolStripMenuItem,
            this.ромбToolStripMenuItem,
            this.нтагонToolStripMenuItem});
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
            this.безиеКриваToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.безиеКриваToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.безиеКриваToolStripMenuItem.Text = "Безие Крива";
            this.безиеКриваToolStripMenuItem.Click += new System.EventHandler(this.безиеКриваToolStripMenuItem_Click);
            // 
            // бСплайнКриваToolStripMenuItem
            // 
            this.бСплайнКриваToolStripMenuItem.Name = "бСплайнКриваToolStripMenuItem";
            this.бСплайнКриваToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.бСплайнКриваToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.бСплайнКриваToolStripMenuItem.Text = "Б-Сплайн Крива";
            this.бСплайнКриваToolStripMenuItem.Click += new System.EventHandler(this.бСплайнКриваToolStripMenuItem_Click);
            // 
            // триъгълникToolStripMenuItem
            // 
            this.триъгълникToolStripMenuItem.Name = "триъгълникToolStripMenuItem";
            this.триъгълникToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.триъгълникToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.триъгълникToolStripMenuItem.Text = "Триъгълник";
            this.триъгълникToolStripMenuItem.Click += new System.EventHandler(this.триъгълникToolStripMenuItem_Click);
            // 
            // ромбToolStripMenuItem
            // 
            this.ромбToolStripMenuItem.Name = "ромбToolStripMenuItem";
            this.ромбToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.ромбToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ромбToolStripMenuItem.Text = "Ромб";
            this.ромбToolStripMenuItem.Click += new System.EventHandler(this.ромбToolStripMenuItem_Click);
            // 
            // нтагонToolStripMenuItem
            // 
            this.нтагонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nTagonSidesTextBox,
            this.хексагонToolStripMenuItem,
            this.хептагонToolStripMenuItem});
            this.нтагонToolStripMenuItem.Name = "нтагонToolStripMenuItem";
            this.нтагонToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.нтагонToolStripMenuItem.Text = "Н-тагон";
            // 
            // nTagonSidesTextBox
            // 
            this.nTagonSidesTextBox.Name = "nTagonSidesTextBox";
            this.nTagonSidesTextBox.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.nTagonSidesTextBox.Size = new System.Drawing.Size(180, 22);
            this.nTagonSidesTextBox.Text = "Пентагон";
            this.nTagonSidesTextBox.Click += new System.EventHandler(this.nTagonSidesTextBox_Click);
            // 
            // хексагонToolStripMenuItem
            // 
            this.хексагонToolStripMenuItem.Name = "хексагонToolStripMenuItem";
            this.хексагонToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.хексагонToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.хексагонToolStripMenuItem.Text = "Хексагон";
            this.хексагонToolStripMenuItem.Click += new System.EventHandler(this.хексагонToolStripMenuItem_Click);
            // 
            // хептагонToolStripMenuItem
            // 
            this.хептагонToolStripMenuItem.Name = "хептагонToolStripMenuItem";
            this.хептагонToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.хептагонToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.хептагонToolStripMenuItem.Text = "Хептагон";
            this.хептагонToolStripMenuItem.Click += new System.EventHandler(this.хептагонToolStripMenuItem_Click);
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
            this.разгрупиранеToolStripMenuItem,
            this.контурToolStripMenuItem});
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
            this.безцветенToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.безцветенToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.безцветенToolStripMenuItem.Text = "Безцветен";
            this.безцветенToolStripMenuItem.Click += new System.EventHandler(this.безцветенToolStripMenuItem_Click);
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
            this.rotate45,
            this.rotate90,
            this.rotate180});
            this.завъртиToolStripMenuItem.Name = "завъртиToolStripMenuItem";
            this.завъртиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.завъртиToolStripMenuItem.Text = "Завъртане";
            // 
            // rotate45
            // 
            this.rotate45.Name = "rotate45";
            this.rotate45.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Left)));
            this.rotate45.Size = new System.Drawing.Size(194, 22);
            this.rotate45.Text = "45°";
            this.rotate45.Click += new System.EventHandler(this.rotate45_Click);
            // 
            // rotate90
            // 
            this.rotate90.Name = "rotate90";
            this.rotate90.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Right)));
            this.rotate90.Size = new System.Drawing.Size(194, 22);
            this.rotate90.Text = "90°";
            this.rotate90.Click += new System.EventHandler(this.rotate90_Click);
            // 
            // rotate180
            // 
            this.rotate180.Name = "rotate180";
            this.rotate180.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Space)));
            this.rotate180.Size = new System.Drawing.Size(194, 22);
            this.rotate180.Text = "180°";
            this.rotate180.Click += new System.EventHandler(this.rotate180_Click);
            // 
            // групиранеToolStripMenuItem
            // 
            this.групиранеToolStripMenuItem.Name = "групиранеToolStripMenuItem";
            this.групиранеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.групиранеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.групиранеToolStripMenuItem.Text = "Групиране";
            this.групиранеToolStripMenuItem.Click += new System.EventHandler(this.групиранеToolStripMenuItem_Click);
            // 
            // разгрупиранеToolStripMenuItem
            // 
            this.разгрупиранеToolStripMenuItem.Name = "разгрупиранеToolStripMenuItem";
            this.разгрупиранеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.разгрупиранеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.разгрупиранеToolStripMenuItem.Text = "Разгрупиране";
            this.разгрупиранеToolStripMenuItem.Click += new System.EventHandler(this.разгрупиранеToolStripMenuItem_Click);
            // 
            // контурToolStripMenuItem
            // 
            this.контурToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удебеляванеToolStripMenuItem,
            this.намалянеToolStripMenuItem});
            this.контурToolStripMenuItem.Name = "контурToolStripMenuItem";
            this.контурToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.контурToolStripMenuItem.Text = "Контур";
            // 
            // удебеляванеToolStripMenuItem
            // 
            this.удебеляванеToolStripMenuItem.Name = "удебеляванеToolStripMenuItem";
            this.удебеляванеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Up)));
            this.удебеляванеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.удебеляванеToolStripMenuItem.Text = "Удебеляване";
            this.удебеляванеToolStripMenuItem.Click += new System.EventHandler(this.удебеляванеToolStripMenuItem_Click);
            // 
            // намалянеToolStripMenuItem
            // 
            this.намалянеToolStripMenuItem.Name = "намалянеToolStripMenuItem";
            this.намалянеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Down)));
            this.намалянеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.намалянеToolStripMenuItem.Text = "Намаляне";
            this.намалянеToolStripMenuItem.Click += new System.EventHandler(this.намалянеToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.преименувайToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Beige;
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel,
            this.coordinatesBox});
            this.statusBar.Location = new System.Drawing.Point(118, 512);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1268, 22);
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
            this.toolStripSeparator4,
            this.pickUpSpeedButton,
            toolStripSeparator1,
            this.toolStripButton3,
            this.drawRectangleSpeedButton,
            this.drawEllipseButton,
            this.drawSquare,
            this.drawCircle,
            this.drawPolygon,
            this.drawStarBtn,
            this.DeleteBtn,
            toolStripSeparator2,
            this.FillColorBtn,
            this.OulineColorBtn,
            toolStripSeparator3,
            this.OppacityBtn,
            this.OppacityTextBox,
            this.OutlineBtn,
            this.OutlineTextBox});
            this.speedMenu.Location = new System.Drawing.Point(0, 0);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.speedMenu.Size = new System.Drawing.Size(118, 534);
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
            this.pickUpSpeedButton.Size = new System.Drawing.Size(115, 24);
            this.pickUpSpeedButton.Text = "Cursor";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(115, 15);
            this.toolStripButton3.Text = "Фигури:";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(115, 24);
            this.drawRectangleSpeedButton.Text = "Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleButtonClick);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(115, 24);
            this.drawEllipseButton.Text = "drawEllipseButton";
            this.drawEllipseButton.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // drawSquare
            // 
            this.drawSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquare.Image = ((System.Drawing.Image)(resources.GetObject("drawSquare.Image")));
            this.drawSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquare.Name = "drawSquare";
            this.drawSquare.Size = new System.Drawing.Size(115, 24);
            this.drawSquare.Text = "drawSquare";
            this.drawSquare.Click += new System.EventHandler(this.drawSquare_Click);
            // 
            // drawCircle
            // 
            this.drawCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircle.Image = ((System.Drawing.Image)(resources.GetObject("drawCircle.Image")));
            this.drawCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircle.Name = "drawCircle";
            this.drawCircle.Size = new System.Drawing.Size(115, 24);
            this.drawCircle.Text = "drawCircle";
            this.drawCircle.Click += new System.EventHandler(this.drawCircle_Click);
            // 
            // drawPolygon
            // 
            this.drawPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawPolygon.BackgroundImage")));
            this.drawPolygon.CheckOnClick = true;
            this.drawPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygon.Image = global::Draw.Properties.Resources.polygonIcon;
            this.drawPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(115, 24);
            this.drawPolygon.Text = "drawPolygon";
            this.drawPolygon.Click += new System.EventHandler(this.drawPolygon_Click);
            // 
            // drawStarBtn
            // 
            this.drawStarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawStarBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawStarBtn.Image")));
            this.drawStarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawStarBtn.Name = "drawStarBtn";
            this.drawStarBtn.Size = new System.Drawing.Size(115, 24);
            this.drawStarBtn.Text = "DrawStarBtn";
            this.drawStarBtn.Click += new System.EventHandler(this.drawStarBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteBtn.Image = global::Draw.Properties.Resources.deleteIcon;
            this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(115, 24);
            this.DeleteBtn.Text = "DeleteBtn";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FillColorBtn
            // 
            this.FillColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("FillColorBtn.Image")));
            this.FillColorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FillColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorBtn.Name = "FillColorBtn";
            this.FillColorBtn.Size = new System.Drawing.Size(115, 24);
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
            this.OulineColorBtn.Size = new System.Drawing.Size(115, 24);
            this.OulineColorBtn.Text = "Цвят на контур:";
            this.OulineColorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OulineColorBtn.Click += new System.EventHandler(this.OulineColorBtn_Click);
            // 
            // OppacityBtn
            // 
            this.OppacityBtn.Image = ((System.Drawing.Image)(resources.GetObject("OppacityBtn.Image")));
            this.OppacityBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OppacityBtn.Name = "OppacityBtn";
            this.OppacityBtn.Size = new System.Drawing.Size(115, 24);
            this.OppacityBtn.Text = "Прозрачност";
            this.OppacityBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OppacityBtn.Click += new System.EventHandler(this.OppacityBtn_Click);
            // 
            // OppacityTextBox
            // 
            this.OppacityTextBox.AcceptsReturn = true;
            this.OppacityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OppacityTextBox.Name = "OppacityTextBox";
            this.OppacityTextBox.Size = new System.Drawing.Size(113, 23);
            // 
            // OutlineBtn
            // 
            this.OutlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("OutlineBtn.Image")));
            this.OutlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutlineBtn.Name = "OutlineBtn";
            this.OutlineBtn.Size = new System.Drawing.Size(115, 24);
            this.OutlineBtn.Text = "Контур";
            this.OutlineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OutlineBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // OutlineTextBox
            // 
            this.OutlineTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OutlineTextBox.Name = "OutlineTextBox";
            this.OutlineTextBox.Size = new System.Drawing.Size(113, 23);
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
            this.viewPort.Location = new System.Drawing.Point(118, 24);
            this.viewPort.Margin = new System.Windows.Forms.Padding(4);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1268, 488);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // преименувайToolStripMenuItem
            // 
            this.преименувайToolStripMenuItem.Name = "преименувайToolStripMenuItem";
            this.преименувайToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.преименувайToolStripMenuItem.Text = "Преименувай";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(115, 6);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Brown;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1200, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 488);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 534);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.speedMenu);
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
        private System.Windows.Forms.ToolStripMenuItem групиранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безиеКриваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бСплайнКриваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem триъгълникToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OppacityBtn;
        private System.Windows.Forms.ToolStripButton DeleteBtn;
        private System.Windows.Forms.ToolStripLabel toolStripButton3;
        private System.Windows.Forms.ToolStripButton OulineColorBtn;
        private System.Windows.Forms.ToolStripMenuItem разгрупиранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton drawStarBtn;
        private System.Windows.Forms.ToolStripMenuItem ромбToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox OutlineTextBox;
        private System.Windows.Forms.ToolStripTextBox OppacityTextBox;
        private System.Windows.Forms.ToolStripButton OutlineBtn;
        private System.Windows.Forms.ToolStripMenuItem контурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удебеляванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem намалянеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate45;
        private System.Windows.Forms.ToolStripMenuItem rotate90;
        private System.Windows.Forms.ToolStripMenuItem rotate180;
        private System.Windows.Forms.ToolStripMenuItem нтагонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nTagonSidesTextBox;
        private System.Windows.Forms.ToolStripMenuItem хексагонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хептагонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преименувайToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ListView listView1;
    }
}
