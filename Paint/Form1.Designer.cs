namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Instruments_panel = new System.Windows.Forms.TableLayoutPanel();
            this.backfonePanel = new System.Windows.Forms.TableLayoutPanel();
            this.backfone = new System.Windows.Forms.PictureBox();
            this.palettePanel = new System.Windows.Forms.TableLayoutPanel();
            this.palette = new System.Windows.Forms.PictureBox();
            this.eraserPanel = new System.Windows.Forms.TableLayoutPanel();
            this.eraser = new System.Windows.Forms.PictureBox();
            this.polygonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.polygon = new System.Windows.Forms.PictureBox();
            this.circlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.circle = new System.Windows.Forms.PictureBox();
            this.linePanel = new System.Windows.Forms.TableLayoutPanel();
            this.line = new System.Windows.Forms.PictureBox();
            this.brushPanel = new System.Windows.Forms.TableLayoutPanel();
            this.brush = new System.Windows.Forms.PictureBox();
            this.pencilPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pencil = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_option = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_PenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comboBox_PenThickness = new System.Windows.Forms.ToolStripComboBox();
            this.menu_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.closeImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_poly = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_comboBox_Poly_AmountOfSides = new System.Windows.Forms.ToolStripComboBox();
            this.menu_comboBox_Poly_turnAngle = new System.Windows.Forms.ToolStripComboBox();
            this.Triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.Square = new System.Windows.Forms.ToolStripMenuItem();
            this.Pentagon = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_additionally = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_additionally_rect = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_additionally_square = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_additionally_circle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fill = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.Instruments_panel.SuspendLayout();
            this.backfonePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backfone)).BeginInit();
            this.palettePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palette)).BeginInit();
            this.eraserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).BeginInit();
            this.polygonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polygon)).BeginInit();
            this.circlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            this.linePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.brushPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brush)).BeginInit();
            this.pencilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pencil)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.375F));
            this.tableLayoutPanel1.Controls.Add(this.picture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Instruments_panel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(640, 410);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseUp);
            // 
            // Instruments_panel
            // 
            this.Instruments_panel.ColumnCount = 1;
            this.Instruments_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Instruments_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Instruments_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Instruments_panel.Controls.Add(this.backfonePanel, 0, 7);
            this.Instruments_panel.Controls.Add(this.palettePanel, 0, 6);
            this.Instruments_panel.Controls.Add(this.eraserPanel, 0, 5);
            this.Instruments_panel.Controls.Add(this.polygonPanel, 0, 4);
            this.Instruments_panel.Controls.Add(this.circlePanel, 0, 3);
            this.Instruments_panel.Controls.Add(this.linePanel, 0, 2);
            this.Instruments_panel.Controls.Add(this.brushPanel, 0, 1);
            this.Instruments_panel.Controls.Add(this.pencilPanel, 0, 0);
            this.Instruments_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Instruments_panel.Location = new System.Drawing.Point(649, 3);
            this.Instruments_panel.Name = "Instruments_panel";
            this.Instruments_panel.RowCount = 8;
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Instruments_panel.Size = new System.Drawing.Size(78, 410);
            this.Instruments_panel.TabIndex = 3;
            // 
            // backfonePanel
            // 
            this.backfonePanel.ColumnCount = 3;
            this.backfonePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.backfonePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.backfonePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.backfonePanel.Controls.Add(this.backfone, 1, 1);
            this.backfonePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backfonePanel.Location = new System.Drawing.Point(3, 360);
            this.backfonePanel.Name = "backfonePanel";
            this.backfonePanel.RowCount = 3;
            this.backfonePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.backfonePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.backfonePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.backfonePanel.Size = new System.Drawing.Size(72, 47);
            this.backfonePanel.TabIndex = 7;
            // 
            // backfone
            // 
            this.backfone.BackColor = System.Drawing.Color.White;
            this.backfone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backfone.Image = global::Paint.Properties.Resources.Material_Icons_e243_1__256;
            this.backfone.Location = new System.Drawing.Point(24, 10);
            this.backfone.Name = "backfone";
            this.backfone.Size = new System.Drawing.Size(22, 26);
            this.backfone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backfone.TabIndex = 0;
            this.backfone.TabStop = false;
            this.backfone.Click += new System.EventHandler(this.Backfone_Click);
            // 
            // palettePanel
            // 
            this.palettePanel.ColumnCount = 3;
            this.palettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.palettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.palettePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.palettePanel.Controls.Add(this.palette, 1, 1);
            this.palettePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palettePanel.Location = new System.Drawing.Point(3, 309);
            this.palettePanel.Name = "palettePanel";
            this.palettePanel.RowCount = 3;
            this.palettePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.palettePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.palettePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.palettePanel.Size = new System.Drawing.Size(72, 45);
            this.palettePanel.TabIndex = 6;
            // 
            // palette
            // 
            this.palette.BackColor = System.Drawing.Color.White;
            this.palette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palette.Image = global::Paint.Properties.Resources.Material_Icons_e3b7_38__256;
            this.palette.Location = new System.Drawing.Point(24, 9);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(22, 25);
            this.palette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palette.TabIndex = 0;
            this.palette.TabStop = false;
            this.palette.Click += new System.EventHandler(this.Palette_Click);
            // 
            // eraserPanel
            // 
            this.eraserPanel.ColumnCount = 3;
            this.eraserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.eraserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.eraserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.eraserPanel.Controls.Add(this.eraser, 1, 1);
            this.eraserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eraserPanel.Location = new System.Drawing.Point(3, 258);
            this.eraserPanel.Name = "eraserPanel";
            this.eraserPanel.RowCount = 3;
            this.eraserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.eraserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.eraserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.eraserPanel.Size = new System.Drawing.Size(72, 45);
            this.eraserPanel.TabIndex = 5;
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.White;
            this.eraser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eraser.Image = global::Paint.Properties.Resources.FontAwesome_f12d_1__256;
            this.eraser.Location = new System.Drawing.Point(24, 9);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(22, 25);
            this.eraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eraser.TabIndex = 0;
            this.eraser.TabStop = false;
            this.eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // polygonPanel
            // 
            this.polygonPanel.ColumnCount = 3;
            this.polygonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.polygonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.polygonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.polygonPanel.Controls.Add(this.polygon, 1, 1);
            this.polygonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polygonPanel.Location = new System.Drawing.Point(3, 207);
            this.polygonPanel.Name = "polygonPanel";
            this.polygonPanel.RowCount = 3;
            this.polygonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.polygonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.polygonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.polygonPanel.Size = new System.Drawing.Size(72, 45);
            this.polygonPanel.TabIndex = 4;
            // 
            // polygon
            // 
            this.polygon.BackColor = System.Drawing.Color.White;
            this.polygon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polygon.Image = global::Paint.Properties.Resources.linea_252_21__256;
            this.polygon.Location = new System.Drawing.Point(24, 9);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(22, 25);
            this.polygon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.polygon.TabIndex = 0;
            this.polygon.TabStop = false;
            this.polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // circlePanel
            // 
            this.circlePanel.ColumnCount = 3;
            this.circlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.circlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.circlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.circlePanel.Controls.Add(this.circle, 1, 1);
            this.circlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circlePanel.Location = new System.Drawing.Point(3, 156);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.RowCount = 3;
            this.circlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.circlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.circlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.circlePanel.Size = new System.Drawing.Size(72, 45);
            this.circlePanel.TabIndex = 3;
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circle.Image = global::Paint.Properties.Resources.Material_Icons_e40c_34__256;
            this.circle.Location = new System.Drawing.Point(24, 9);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(22, 25);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle.TabIndex = 0;
            this.circle.TabStop = false;
            this.circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // linePanel
            // 
            this.linePanel.ColumnCount = 3;
            this.linePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.linePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.linePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.linePanel.Controls.Add(this.line, 1, 1);
            this.linePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linePanel.Location = new System.Drawing.Point(3, 105);
            this.linePanel.Name = "linePanel";
            this.linePanel.RowCount = 3;
            this.linePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.linePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.linePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.linePanel.Size = new System.Drawing.Size(72, 45);
            this.linePanel.TabIndex = 2;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.line.Image = global::Paint.Properties.Resources.et_line_e032_9__256;
            this.line.Location = new System.Drawing.Point(24, 9);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(22, 25);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line.TabIndex = 0;
            this.line.TabStop = false;
            this.line.Click += new System.EventHandler(this.Line_Click);
            // 
            // brushPanel
            // 
            this.brushPanel.ColumnCount = 3;
            this.brushPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.brushPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.brushPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.brushPanel.Controls.Add(this.brush, 1, 1);
            this.brushPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brushPanel.Location = new System.Drawing.Point(3, 54);
            this.brushPanel.Name = "brushPanel";
            this.brushPanel.RowCount = 3;
            this.brushPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.brushPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.brushPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.brushPanel.Size = new System.Drawing.Size(72, 45);
            this.brushPanel.TabIndex = 1;
            // 
            // brush
            // 
            this.brush.BackColor = System.Drawing.Color.White;
            this.brush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brush.Image = global::Paint.Properties.Resources.Entypo_e79a_0__256;
            this.brush.Location = new System.Drawing.Point(24, 9);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(22, 25);
            this.brush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brush.TabIndex = 0;
            this.brush.TabStop = false;
            this.brush.Click += new System.EventHandler(this.Brush_Click);
            // 
            // pencilPanel
            // 
            this.pencilPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pencilPanel.ColumnCount = 3;
            this.pencilPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pencilPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pencilPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pencilPanel.Controls.Add(this.pencil, 1, 1);
            this.pencilPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pencilPanel.Location = new System.Drawing.Point(3, 3);
            this.pencilPanel.Name = "pencilPanel";
            this.pencilPanel.RowCount = 3;
            this.pencilPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pencilPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pencilPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.pencilPanel.Size = new System.Drawing.Size(72, 45);
            this.pencilPanel.TabIndex = 0;
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.White;
            this.pencil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pencil.Image = global::Paint.Properties.Resources.FontAwesome_f040_0__256;
            this.pencil.Location = new System.Drawing.Point(24, 9);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(22, 25);
            this.pencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pencil.TabIndex = 0;
            this.pencil.TabStop = false;
            this.pencil.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_file,
            this.Menu_option,
            this.menu_additionally,
            this.menu_fill});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_file
            // 
            this.Menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Open,
            this.menu_SaveAs,
            this.menu_Close});
            this.Menu_file.Name = "Menu_file";
            this.Menu_file.Size = new System.Drawing.Size(59, 24);
            this.Menu_file.Text = "Файл";
            // 
            // menu_Open
            // 
            this.menu_Open.Name = "menu_Open";
            this.menu_Open.Size = new System.Drawing.Size(192, 26);
            this.menu_Open.Text = "Открыть";
            this.menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // menu_SaveAs
            // 
            this.menu_SaveAs.Name = "menu_SaveAs";
            this.menu_SaveAs.Size = new System.Drawing.Size(192, 26);
            this.menu_SaveAs.Text = "Сохранить как";
            this.menu_SaveAs.Click += new System.EventHandler(this.Menu_SaveAs_Click);
            // 
            // menu_Close
            // 
            this.menu_Close.Name = "menu_Close";
            this.menu_Close.Size = new System.Drawing.Size(192, 26);
            this.menu_Close.Text = "Выход";
            this.menu_Close.Click += new System.EventHandler(this.Menu_Close_Click);
            // 
            // Menu_option
            // 
            this.Menu_option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_PenColor,
            this.menu_comboBox_PenThickness,
            this.menu_BackColor,
            this.menu_DeleteAll,
            this.closeImage,
            this.menu_poly});
            this.Menu_option.Name = "Menu_option";
            this.Menu_option.Size = new System.Drawing.Size(104, 24);
            this.Menu_option.Text = "Параметры";
            // 
            // menu_PenColor
            // 
            this.menu_PenColor.Name = "menu_PenColor";
            this.menu_PenColor.Size = new System.Drawing.Size(249, 26);
            this.menu_PenColor.Text = "Цвет пера";
            this.menu_PenColor.Click += new System.EventHandler(this.Menu_PenColor_Click);
            // 
            // menu_comboBox_PenThickness
            // 
            this.menu_comboBox_PenThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "7",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "45",
            "50",
            "60",
            "70",
            "80"});
            this.menu_comboBox_PenThickness.Name = "menu_comboBox_PenThickness";
            this.menu_comboBox_PenThickness.Size = new System.Drawing.Size(130, 28);
            this.menu_comboBox_PenThickness.Text = "Толцина пера";
            this.menu_comboBox_PenThickness.TextChanged += new System.EventHandler(this.Menu_comboBox_PenThickness_TextChanged);
            // 
            // menu_BackColor
            // 
            this.menu_BackColor.Name = "menu_BackColor";
            this.menu_BackColor.Size = new System.Drawing.Size(249, 26);
            this.menu_BackColor.Text = "Цвет фона";
            this.menu_BackColor.Click += new System.EventHandler(this.Menu_BackColor_Click);
            // 
            // menu_DeleteAll
            // 
            this.menu_DeleteAll.Name = "menu_DeleteAll";
            this.menu_DeleteAll.Size = new System.Drawing.Size(249, 26);
            this.menu_DeleteAll.Text = "Стереть все";
            this.menu_DeleteAll.Click += new System.EventHandler(this.Menu_DeleteAll_Click);
            // 
            // closeImage
            // 
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(249, 26);
            this.closeImage.Text = "Закрыть изображение";
            this.closeImage.Click += new System.EventHandler(this.CloseImage_Click);
            // 
            // menu_poly
            // 
            this.menu_poly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_comboBox_Poly_AmountOfSides,
            this.menu_comboBox_Poly_turnAngle,
            this.Triangle,
            this.Square,
            this.Pentagon});
            this.menu_poly.Name = "menu_poly";
            this.menu_poly.Size = new System.Drawing.Size(249, 26);
            this.menu_poly.Text = "Многоугольник";
            // 
            // menu_comboBox_Poly_AmountOfSides
            // 
            this.menu_comboBox_Poly_AmountOfSides.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.menu_comboBox_Poly_AmountOfSides.Name = "menu_comboBox_Poly_AmountOfSides";
            this.menu_comboBox_Poly_AmountOfSides.Size = new System.Drawing.Size(135, 28);
            this.menu_comboBox_Poly_AmountOfSides.Text = "Кол-во сторон";
            this.menu_comboBox_Poly_AmountOfSides.TextChanged += new System.EventHandler(this.Menu_comboBox_Poly_AmountOfSides_TextChanged);
            // 
            // menu_comboBox_Poly_turnAngle
            // 
            this.menu_comboBox_Poly_turnAngle.Items.AddRange(new object[] {
            "0",
            "30",
            "45",
            "60",
            "90",
            "120",
            "135",
            "150",
            "180"});
            this.menu_comboBox_Poly_turnAngle.Name = "menu_comboBox_Poly_turnAngle";
            this.menu_comboBox_Poly_turnAngle.Size = new System.Drawing.Size(135, 28);
            this.menu_comboBox_Poly_turnAngle.Text = "Угол поворота";
            this.menu_comboBox_Poly_turnAngle.TextChanged += new System.EventHandler(this.Menu_comboBox_Poly_turnAngle_TextChanged);
            // 
            // Triangle
            // 
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(209, 26);
            this.Triangle.Text = "Треугольник";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Square
            // 
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(209, 26);
            this.Square.Text = "Квадрат";
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Pentagon
            // 
            this.Pentagon.Name = "Pentagon";
            this.Pentagon.Size = new System.Drawing.Size(209, 26);
            this.Pentagon.Text = "5-угольник";
            this.Pentagon.Click += new System.EventHandler(this.Pentagon_Click);
            // 
            // menu_additionally
            // 
            this.menu_additionally.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_additionally_rect,
            this.menu_additionally_square,
            this.menu_additionally_circle});
            this.menu_additionally.Name = "menu_additionally";
            this.menu_additionally.Size = new System.Drawing.Size(134, 24);
            this.menu_additionally.Text = "Дополнительно";
            // 
            // menu_additionally_rect
            // 
            this.menu_additionally_rect.Name = "menu_additionally_rect";
            this.menu_additionally_rect.Size = new System.Drawing.Size(203, 26);
            this.menu_additionally_rect.Text = "Прямоугольник";
            this.menu_additionally_rect.Click += new System.EventHandler(this.Menu_additionally_rect_Click);
            // 
            // menu_additionally_square
            // 
            this.menu_additionally_square.Name = "menu_additionally_square";
            this.menu_additionally_square.Size = new System.Drawing.Size(203, 26);
            this.menu_additionally_square.Text = "Квадрат";
            this.menu_additionally_square.Click += new System.EventHandler(this.Menu_additionally_square_Click);
            // 
            // menu_additionally_circle
            // 
            this.menu_additionally_circle.Name = "menu_additionally_circle";
            this.menu_additionally_circle.Size = new System.Drawing.Size(203, 26);
            this.menu_additionally_circle.Text = "Круг";
            this.menu_additionally_circle.Click += new System.EventHandler(this.Menu_additionally_circle_Click);
            // 
            // menu_fill
            // 
            this.menu_fill.Name = "menu_fill";
            this.menu_fill.Size = new System.Drawing.Size(79, 24);
            this.menu_fill.Text = "Заливка";
            this.menu_fill.Click += new System.EventHandler(this.Menu_fill_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EV\'s Paint | v.1.0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.Instruments_panel.ResumeLayout(false);
            this.backfonePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backfone)).EndInit();
            this.palettePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palette)).EndInit();
            this.eraserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).EndInit();
            this.polygonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polygon)).EndInit();
            this.circlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            this.linePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.brushPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brush)).EndInit();
            this.pencilPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pencil)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_file;
        private System.Windows.Forms.ToolStripMenuItem Menu_option;
        private System.Windows.Forms.ToolStripMenuItem menu_PenColor;
        private System.Windows.Forms.ToolStripComboBox menu_comboBox_PenThickness;
        private System.Windows.Forms.ToolStripMenuItem menu_Open;
        private System.Windows.Forms.ToolStripMenuItem menu_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem menu_Close;
        private System.Windows.Forms.ToolStripMenuItem menu_BackColor;
        private System.Windows.Forms.ToolStripMenuItem menu_DeleteAll;
        private System.Windows.Forms.TableLayoutPanel Instruments_panel;
        private System.Windows.Forms.TableLayoutPanel pencilPanel;
        private System.Windows.Forms.PictureBox pencil;
        private System.Windows.Forms.TableLayoutPanel polygonPanel;
        private System.Windows.Forms.PictureBox polygon;
        private System.Windows.Forms.TableLayoutPanel circlePanel;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.TableLayoutPanel linePanel;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.TableLayoutPanel brushPanel;
        private System.Windows.Forms.PictureBox brush;
        private System.Windows.Forms.TableLayoutPanel backfonePanel;
        private System.Windows.Forms.PictureBox backfone;
        private System.Windows.Forms.TableLayoutPanel palettePanel;
        private System.Windows.Forms.PictureBox palette;
        private System.Windows.Forms.TableLayoutPanel eraserPanel;
        private System.Windows.Forms.PictureBox eraser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem closeImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menu_poly;
        private System.Windows.Forms.ToolStripComboBox menu_comboBox_Poly_AmountOfSides;
        private System.Windows.Forms.ToolStripComboBox menu_comboBox_Poly_turnAngle;
        private System.Windows.Forms.ToolStripMenuItem Triangle;
        private System.Windows.Forms.ToolStripMenuItem Square;
        private System.Windows.Forms.ToolStripMenuItem Pentagon;
        private System.Windows.Forms.ToolStripMenuItem menu_fill;
        private System.Windows.Forms.ToolStripMenuItem menu_additionally;
        private System.Windows.Forms.ToolStripMenuItem menu_additionally_rect;
        private System.Windows.Forms.ToolStripMenuItem menu_additionally_square;
        private System.Windows.Forms.ToolStripMenuItem menu_additionally_circle;
    }
}

