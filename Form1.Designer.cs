namespace Fractal_Structures
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Fractal = new System.Windows.Forms.GroupBox();
            this.radioButton_ImportIFS = new System.Windows.Forms.RadioButton();
            this.radioButton_Tree2 = new System.Windows.Forms.RadioButton();
            this.radioButton_SirCarp = new System.Windows.Forms.RadioButton();
            this.radioButton_Vic = new System.Windows.Forms.RadioButton();
            this.radioButton_SirPenta = new System.Windows.Forms.RadioButton();
            this.radioButton_CantorLab = new System.Windows.Forms.RadioButton();
            this.radioButton_TwinDragon = new System.Windows.Forms.RadioButton();
            this.radioButton_Tree = new System.Windows.Forms.RadioButton();
            this.radioButton_BarnFern4 = new System.Windows.Forms.RadioButton();
            this.radioButton_BarnFern3 = new System.Windows.Forms.RadioButton();
            this.radioButton_BarnFern2 = new System.Windows.Forms.RadioButton();
            this.radioButton_BarnFern1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Koch = new System.Windows.Forms.RadioButton();
            this.radioButton_Sirpinski = new System.Windows.Forms.RadioButton();
            this.radioButton_non = new System.Windows.Forms.RadioButton();
            this.radioButton_Last = new System.Windows.Forms.RadioButton();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_Scale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Scaling = new System.Windows.Forms.TextBox();
            this.textBox_Points = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_IFSName = new System.Windows.Forms.TextBox();
            this.FractalName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Safe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Load = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.labelXShift = new System.Windows.Forms.Label();
            this.labelYShift = new System.Windows.Forms.Label();
            this.textBox_YShift = new System.Windows.Forms.TextBox();
            this.textBox_XShift = new System.Windows.Forms.TextBox();
            this.toolStripButton_Info = new System.Windows.Forms.ToolStripButton();
            this.groupBox_Fractal.SuspendLayout();
            this.groupBox_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Fractal
            // 
            this.groupBox_Fractal.Controls.Add(this.radioButton_ImportIFS);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Tree2);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SirCarp);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Vic);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SirPenta);
            this.groupBox_Fractal.Controls.Add(this.radioButton_CantorLab);
            this.groupBox_Fractal.Controls.Add(this.radioButton_TwinDragon);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Tree);
            this.groupBox_Fractal.Controls.Add(this.radioButton_BarnFern4);
            this.groupBox_Fractal.Controls.Add(this.pictureBox1);
            this.groupBox_Fractal.Controls.Add(this.radioButton_BarnFern3);
            this.groupBox_Fractal.Controls.Add(this.radioButton_BarnFern2);
            this.groupBox_Fractal.Controls.Add(this.radioButton_BarnFern1);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Koch);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Sirpinski);
            this.groupBox_Fractal.Location = new System.Drawing.Point(531, 28);
            this.groupBox_Fractal.Name = "groupBox_Fractal";
            this.groupBox_Fractal.Size = new System.Drawing.Size(523, 321);
            this.groupBox_Fractal.TabIndex = 4;
            this.groupBox_Fractal.TabStop = false;
            this.groupBox_Fractal.Text = "Examples";
            // 
            // radioButton_ImportIFS
            // 
            this.radioButton_ImportIFS.AutoSize = true;
            this.radioButton_ImportIFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ImportIFS.Location = new System.Drawing.Point(257, 283);
            this.radioButton_ImportIFS.Name = "radioButton_ImportIFS";
            this.radioButton_ImportIFS.Size = new System.Drawing.Size(135, 28);
            this.radioButton_ImportIFS.TabIndex = 17;
            this.radioButton_ImportIFS.Text = "Imported IFS";
            this.radioButton_ImportIFS.UseVisualStyleBackColor = true;
            this.radioButton_ImportIFS.Click += new System.EventHandler(this.toolStripButton_Load_Click);
            // 
            // radioButton_Tree2
            // 
            this.radioButton_Tree2.AutoSize = true;
            this.radioButton_Tree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Tree2.Location = new System.Drawing.Point(258, 239);
            this.radioButton_Tree2.Name = "radioButton_Tree2";
            this.radioButton_Tree2.Size = new System.Drawing.Size(127, 28);
            this.radioButton_Tree2.TabIndex = 16;
            this.radioButton_Tree2.Text = "Winter Tree";
            this.radioButton_Tree2.UseVisualStyleBackColor = true;
            this.radioButton_Tree2.CheckedChanged += new System.EventHandler(this.radioButton_Tree2_CheckedChanged);
            // 
            // radioButton_SirCarp
            // 
            this.radioButton_SirCarp.AutoSize = true;
            this.radioButton_SirCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SirCarp.Location = new System.Drawing.Point(21, 283);
            this.radioButton_SirCarp.Name = "radioButton_SirCarp";
            this.radioButton_SirCarp.Size = new System.Drawing.Size(169, 28);
            this.radioButton_SirCarp.TabIndex = 15;
            this.radioButton_SirCarp.Text = "Sierpiński Carpet";
            this.radioButton_SirCarp.UseVisualStyleBackColor = true;
            this.radioButton_SirCarp.CheckedChanged += new System.EventHandler(this.radioButton_SirCarp_CheckedChanged);
            // 
            // radioButton_Vic
            // 
            this.radioButton_Vic.AutoSize = true;
            this.radioButton_Vic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Vic.Location = new System.Drawing.Point(20, 239);
            this.radioButton_Vic.Name = "radioButton_Vic";
            this.radioButton_Vic.Size = new System.Drawing.Size(145, 28);
            this.radioButton_Vic.TabIndex = 14;
            this.radioButton_Vic.Text = "Vicsek Fractal";
            this.radioButton_Vic.UseVisualStyleBackColor = true;
            this.radioButton_Vic.CheckedChanged += new System.EventHandler(this.radioButton_Vic_CheckedChanged);
            // 
            // radioButton_SirPenta
            // 
            this.radioButton_SirPenta.AutoSize = true;
            this.radioButton_SirPenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SirPenta.Location = new System.Drawing.Point(21, 193);
            this.radioButton_SirPenta.Name = "radioButton_SirPenta";
            this.radioButton_SirPenta.Size = new System.Drawing.Size(205, 28);
            this.radioButton_SirPenta.TabIndex = 13;
            this.radioButton_SirPenta.Text = "Sierpiński Pentagram";
            this.radioButton_SirPenta.UseVisualStyleBackColor = true;
            this.radioButton_SirPenta.CheckedChanged += new System.EventHandler(this.radioButton_SirPenta_CheckedChanged);
            // 
            // radioButton_CantorLab
            // 
            this.radioButton_CantorLab.AutoSize = true;
            this.radioButton_CantorLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CantorLab.Location = new System.Drawing.Point(21, 146);
            this.radioButton_CantorLab.Name = "radioButton_CantorLab";
            this.radioButton_CantorLab.Size = new System.Drawing.Size(164, 28);
            this.radioButton_CantorLab.TabIndex = 12;
            this.radioButton_CantorLab.Text = "Cantor Labyrinth";
            this.radioButton_CantorLab.UseVisualStyleBackColor = true;
            this.radioButton_CantorLab.CheckedChanged += new System.EventHandler(this.radioButton_CantorLab_CheckedChanged);
            // 
            // radioButton_TwinDragon
            // 
            this.radioButton_TwinDragon.AutoSize = true;
            this.radioButton_TwinDragon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_TwinDragon.Location = new System.Drawing.Point(20, 102);
            this.radioButton_TwinDragon.Name = "radioButton_TwinDragon";
            this.radioButton_TwinDragon.Size = new System.Drawing.Size(129, 28);
            this.radioButton_TwinDragon.TabIndex = 11;
            this.radioButton_TwinDragon.Text = "Twindragon";
            this.radioButton_TwinDragon.UseVisualStyleBackColor = true;
            this.radioButton_TwinDragon.CheckedChanged += new System.EventHandler(this.radioButton_TwinDragon_CheckedChanged);
            // 
            // radioButton_Tree
            // 
            this.radioButton_Tree.AutoSize = true;
            this.radioButton_Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Tree.Location = new System.Drawing.Point(258, 23);
            this.radioButton_Tree.Name = "radioButton_Tree";
            this.radioButton_Tree.Size = new System.Drawing.Size(131, 28);
            this.radioButton_Tree.TabIndex = 10;
            this.radioButton_Tree.Text = "Simple Tree";
            this.radioButton_Tree.UseVisualStyleBackColor = true;
            this.radioButton_Tree.CheckedChanged += new System.EventHandler(this.radioButton_Tree_CheckedChanged);
            // 
            // radioButton_BarnFern4
            // 
            this.radioButton_BarnFern4.AutoSize = true;
            this.radioButton_BarnFern4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BarnFern4.Location = new System.Drawing.Point(258, 193);
            this.radioButton_BarnFern4.Name = "radioButton_BarnFern4";
            this.radioButton_BarnFern4.Size = new System.Drawing.Size(63, 28);
            this.radioButton_BarnFern4.TabIndex = 9;
            this.radioButton_BarnFern4.Text = "Leaf";
            this.radioButton_BarnFern4.UseVisualStyleBackColor = true;
            this.radioButton_BarnFern4.CheckedChanged += new System.EventHandler(this.radioButton_BarnFern4_CheckedChanged);
            // 
            // radioButton_BarnFern3
            // 
            this.radioButton_BarnFern3.AutoSize = true;
            this.radioButton_BarnFern3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BarnFern3.Location = new System.Drawing.Point(258, 146);
            this.radioButton_BarnFern3.Name = "radioButton_BarnFern3";
            this.radioButton_BarnFern3.Size = new System.Drawing.Size(255, 28);
            this.radioButton_BarnFern3.TabIndex = 8;
            this.radioButton_BarnFern3.Text = "Fern #3 (Leptosporangiate)";
            this.radioButton_BarnFern3.UseVisualStyleBackColor = true;
            this.radioButton_BarnFern3.CheckedChanged += new System.EventHandler(this.radioButton_BarnFern3_CheckedChanged);
            // 
            // radioButton_BarnFern2
            // 
            this.radioButton_BarnFern2.AutoSize = true;
            this.radioButton_BarnFern2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BarnFern2.Location = new System.Drawing.Point(257, 102);
            this.radioButton_BarnFern2.Name = "radioButton_BarnFern2";
            this.radioButton_BarnFern2.Size = new System.Drawing.Size(256, 28);
            this.radioButton_BarnFern2.TabIndex = 7;
            this.radioButton_BarnFern2.Text = "Fern #2 (Thelypteridaceae)";
            this.radioButton_BarnFern2.UseVisualStyleBackColor = true;
            this.radioButton_BarnFern2.CheckedChanged += new System.EventHandler(this.radioButton_BarnFern2_CheckedChanged);
            // 
            // radioButton_BarnFern1
            // 
            this.radioButton_BarnFern1.AutoSize = true;
            this.radioButton_BarnFern1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_BarnFern1.Location = new System.Drawing.Point(257, 60);
            this.radioButton_BarnFern1.Name = "radioButton_BarnFern1";
            this.radioButton_BarnFern1.Size = new System.Drawing.Size(145, 28);
            this.radioButton_BarnFern1.TabIndex = 6;
            this.radioButton_BarnFern1.Text = "Barnsley Fern";
            this.radioButton_BarnFern1.UseVisualStyleBackColor = true;
            this.radioButton_BarnFern1.CheckedChanged += new System.EventHandler(this.radioButton_BarnFern1_CheckedChanged);
            // 
            // radioButton_Koch
            // 
            this.radioButton_Koch.AutoSize = true;
            this.radioButton_Koch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Koch.Location = new System.Drawing.Point(20, 60);
            this.radioButton_Koch.Name = "radioButton_Koch";
            this.radioButton_Koch.Size = new System.Drawing.Size(127, 28);
            this.radioButton_Koch.TabIndex = 5;
            this.radioButton_Koch.Text = "Koch Curve";
            this.radioButton_Koch.UseVisualStyleBackColor = true;
            this.radioButton_Koch.CheckedChanged += new System.EventHandler(this.radioButton_Koch_CheckedChanged);
            // 
            // radioButton_Sirpinski
            // 
            this.radioButton_Sirpinski.AutoSize = true;
            this.radioButton_Sirpinski.Checked = true;
            this.radioButton_Sirpinski.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Sirpinski.Location = new System.Drawing.Point(20, 23);
            this.radioButton_Sirpinski.Name = "radioButton_Sirpinski";
            this.radioButton_Sirpinski.Size = new System.Drawing.Size(183, 28);
            this.radioButton_Sirpinski.TabIndex = 4;
            this.radioButton_Sirpinski.TabStop = true;
            this.radioButton_Sirpinski.Text = "Sierpiński Triangle";
            this.radioButton_Sirpinski.UseVisualStyleBackColor = true;
            this.radioButton_Sirpinski.CheckedChanged += new System.EventHandler(this.radioButton_Sirpinski_CheckedChanged);
            // 
            // radioButton_non
            // 
            this.radioButton_non.AutoSize = true;
            this.radioButton_non.Checked = true;
            this.radioButton_non.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_non.Location = new System.Drawing.Point(11, 19);
            this.radioButton_non.Name = "radioButton_non";
            this.radioButton_non.Size = new System.Drawing.Size(108, 28);
            this.radioButton_non.TabIndex = 5;
            this.radioButton_non.TabStop = true;
            this.radioButton_non.Text = "w/o Color";
            this.radioButton_non.UseVisualStyleBackColor = true;
            // 
            // radioButton_Last
            // 
            this.radioButton_Last.AutoSize = true;
            this.radioButton_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Last.Location = new System.Drawing.Point(11, 59);
            this.radioButton_Last.Name = "radioButton_Last";
            this.radioButton_Last.Size = new System.Drawing.Size(97, 28);
            this.radioButton_Last.TabIndex = 6;
            this.radioButton_Last.Text = "w/ Color";
            this.radioButton_Last.UseVisualStyleBackColor = true;
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.radioButton_Last);
            this.groupBox_Color.Controls.Add(this.radioButton_non);
            this.groupBox_Color.Location = new System.Drawing.Point(387, 28);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(138, 105);
            this.groupBox_Color.TabIndex = 8;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Color";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 151);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(509, 198);
            this.dataGridView2.TabIndex = 10;
            // 
            // label_Scale
            // 
            this.label_Scale.AutoSize = true;
            this.label_Scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Scale.Location = new System.Drawing.Point(256, 109);
            this.label_Scale.Name = "label_Scale";
            this.label_Scale.Size = new System.Drawing.Size(72, 24);
            this.label_Scale.TabIndex = 12;
            this.label_Scale.Text = "Scaling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number of Points";
            // 
            // textBox_Scaling
            // 
            this.textBox_Scaling.Location = new System.Drawing.Point(327, 111);
            this.textBox_Scaling.Name = "textBox_Scaling";
            this.textBox_Scaling.Size = new System.Drawing.Size(54, 20);
            this.textBox_Scaling.TabIndex = 14;
            this.textBox_Scaling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Scaling_KeyPress);
            // 
            // textBox_Points
            // 
            this.textBox_Points.Location = new System.Drawing.Point(173, 70);
            this.textBox_Points.Name = "textBox_Points";
            this.textBox_Points.Size = new System.Drawing.Size(204, 20);
            this.textBox_Points.TabIndex = 15;
            this.textBox_Points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Points_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Fractal_Structures.Properties.Resources.S_NUF_2020_QR_Code;
            this.pictureBox1.Image = global::Fractal_Structures.Properties.Resources.SNUF2020_Logo_QR_Code;
            this.pictureBox1.Location = new System.Drawing.Point(431, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_IFSName
            // 
            this.textBox_IFSName.Location = new System.Drawing.Point(115, 32);
            this.textBox_IFSName.Name = "textBox_IFSName";
            this.textBox_IFSName.Size = new System.Drawing.Size(262, 20);
            this.textBox_IFSName.TabIndex = 19;
            this.textBox_IFSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IFSName_KeyPress);
            // 
            // FractalName
            // 
            this.FractalName.AutoSize = true;
            this.FractalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FractalName.Location = new System.Drawing.Point(12, 28);
            this.FractalName.Name = "FractalName";
            this.FractalName.Size = new System.Drawing.Size(94, 24);
            this.FractalName.TabIndex = 18;
            this.FractalName.Text = "IFS Name";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Safe,
            this.toolStripButton_Load,
            this.toolStripButton_Info,
            this.toolStripButton_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton_Start.Text = "Start IFS";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            // 
            // toolStripButton_Safe
            // 
            this.toolStripButton_Safe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Safe.Image")));
            this.toolStripButton_Safe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Safe.Name = "toolStripButton_Safe";
            this.toolStripButton_Safe.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton_Safe.Text = "Safe IFS";
            this.toolStripButton_Safe.Click += new System.EventHandler(this.toolStripButton_Safe_Click);
            // 
            // toolStripButton_Load
            // 
            this.toolStripButton_Load.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Load.Image")));
            this.toolStripButton_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Load.Name = "toolStripButton_Load";
            this.toolStripButton_Load.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton_Load.Text = "Load IFS";
            this.toolStripButton_Load.Click += new System.EventHandler(this.toolStripButton_Load_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton_Exit.Text = "Exit Program";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // labelXShift
            // 
            this.labelXShift.AutoSize = true;
            this.labelXShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXShift.Location = new System.Drawing.Point(12, 109);
            this.labelXShift.Name = "labelXShift";
            this.labelXShift.Size = new System.Drawing.Size(70, 24);
            this.labelXShift.TabIndex = 21;
            this.labelXShift.Text = "X-Shift ";
            // 
            // labelYShift
            // 
            this.labelYShift.AutoSize = true;
            this.labelYShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYShift.Location = new System.Drawing.Point(133, 109);
            this.labelYShift.Name = "labelYShift";
            this.labelYShift.Size = new System.Drawing.Size(68, 24);
            this.labelYShift.TabIndex = 22;
            this.labelYShift.Text = "Y-Shift ";
            // 
            // textBox_YShift
            // 
            this.textBox_YShift.Location = new System.Drawing.Point(197, 113);
            this.textBox_YShift.Name = "textBox_YShift";
            this.textBox_YShift.Size = new System.Drawing.Size(54, 20);
            this.textBox_YShift.TabIndex = 23;
            this.textBox_YShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_YShift_KeyPress);
            // 
            // textBox_XShift
            // 
            this.textBox_XShift.Location = new System.Drawing.Point(79, 111);
            this.textBox_XShift.Name = "textBox_XShift";
            this.textBox_XShift.Size = new System.Drawing.Size(54, 20);
            this.textBox_XShift.TabIndex = 24;
            this.textBox_XShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_XShift_KeyPress);
            // 
            // toolStripButton_Info
            // 
            this.toolStripButton_Info.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Info.Image")));
            this.toolStripButton_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Info.Name = "toolStripButton_Info";
            this.toolStripButton_Info.Size = new System.Drawing.Size(90, 22);
            this.toolStripButton_Info.Text = "Information";
            this.toolStripButton_Info.Click += new System.EventHandler(this.toolStripButton_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 364);
            this.Controls.Add(this.textBox_XShift);
            this.Controls.Add(this.textBox_YShift);
            this.Controls.Add(this.labelYShift);
            this.Controls.Add(this.labelXShift);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_IFSName);
            this.Controls.Add(this.FractalName);
            this.Controls.Add(this.textBox_Points);
            this.Controls.Add(this.textBox_Scaling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Scale);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox_Color);
            this.Controls.Add(this.groupBox_Fractal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fractal Structures by Iterative Function System (IFS) - Random Jump";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Fractal.ResumeLayout(false);
            this.groupBox_Fractal.PerformLayout();
            this.groupBox_Color.ResumeLayout(false);
            this.groupBox_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Fractal;
        private System.Windows.Forms.RadioButton radioButton_Sirpinski;
        private System.Windows.Forms.RadioButton radioButton_non;
        private System.Windows.Forms.RadioButton radioButton_Last;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private System.Windows.Forms.RadioButton radioButton_BarnFern4;
        private System.Windows.Forms.RadioButton radioButton_BarnFern3;
        private System.Windows.Forms.RadioButton radioButton_BarnFern2;
        private System.Windows.Forms.RadioButton radioButton_BarnFern1;
        private System.Windows.Forms.RadioButton radioButton_Koch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton_Tree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Scale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Scaling;
        private System.Windows.Forms.TextBox textBox_Points;
        private System.Windows.Forms.RadioButton radioButton_TwinDragon;
        private System.Windows.Forms.RadioButton radioButton_CantorLab;
        private System.Windows.Forms.RadioButton radioButton_SirPenta;
        private System.Windows.Forms.RadioButton radioButton_Vic;
        private System.Windows.Forms.RadioButton radioButton_SirCarp;
        private System.Windows.Forms.RadioButton radioButton_Tree2;
        private System.Windows.Forms.TextBox textBox_IFSName;
        private System.Windows.Forms.Label FractalName;
        private System.Windows.Forms.RadioButton radioButton_ImportIFS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Safe;
        private System.Windows.Forms.ToolStripButton toolStripButton_Load;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.ToolStripButton toolStripButton_Info;
        private System.Windows.Forms.Label labelXShift;
        private System.Windows.Forms.Label labelYShift;
        private System.Windows.Forms.TextBox textBox_YShift;
        private System.Windows.Forms.TextBox textBox_XShift;
    }
}

