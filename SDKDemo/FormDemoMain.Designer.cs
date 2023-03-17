namespace SDKDemo
{
    partial class FormDemoMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nmCouchVrt = new System.Windows.Forms.NumericUpDown();
            this.nmCouchLng = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmCouchLat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmCouchAngle = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numY2 = new System.Windows.Forms.NumericUpDown();
            this.numY1 = new System.Windows.Forms.NumericUpDown();
            this.numX2 = new System.Windows.Forms.NumericUpDown();
            this.numX1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmCollAngle = new System.Windows.Forms.NumericUpDown();
            this.nmGantryAngle = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonBoard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBeamOn = new System.Windows.Forms.Button();
            this.buttonBeamOff = new System.Windows.Forms.Button();
            this.buttonFieldLight = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.vrtPlan = new System.Windows.Forms.Label();
            this.collPlan = new System.Windows.Forms.Label();
            this.gantryPlan = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchVrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchLng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchAngle)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCollAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGantryAngle)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(21, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "VRT";
            // 
            // nmCouchVrt
            // 
            this.nmCouchVrt.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmCouchVrt.ForeColor = System.Drawing.Color.SteelBlue;
            this.nmCouchVrt.Location = new System.Drawing.Point(8, 24);
            this.nmCouchVrt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmCouchVrt.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nmCouchVrt.Name = "nmCouchVrt";
            this.nmCouchVrt.Size = new System.Drawing.Size(65, 29);
            this.nmCouchVrt.TabIndex = 185;
            this.nmCouchVrt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nmCouchVrt_MouseUp);
            // 
            // nmCouchLng
            // 
            this.nmCouchLng.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmCouchLng.ForeColor = System.Drawing.Color.SteelBlue;
            this.nmCouchLng.Location = new System.Drawing.Point(95, 24);
            this.nmCouchLng.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nmCouchLng.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            -2147483648});
            this.nmCouchLng.Name = "nmCouchLng";
            this.nmCouchLng.Size = new System.Drawing.Size(65, 29);
            this.nmCouchLng.TabIndex = 199;
            this.nmCouchLng.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nmCouchLng_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(110, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 195;
            this.label5.Text = "LNG";
            // 
            // nmCouchLat
            // 
            this.nmCouchLat.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmCouchLat.ForeColor = System.Drawing.Color.SteelBlue;
            this.nmCouchLat.Location = new System.Drawing.Point(179, 24);
            this.nmCouchLat.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nmCouchLat.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            -2147483648});
            this.nmCouchLat.Name = "nmCouchLat";
            this.nmCouchLat.Size = new System.Drawing.Size(65, 29);
            this.nmCouchLat.TabIndex = 200;
            this.nmCouchLat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nmCouchLat_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(196, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 196;
            this.label6.Text = "LAT";
            // 
            // nmCouchAngle
            // 
            this.nmCouchAngle.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmCouchAngle.ForeColor = System.Drawing.Color.SteelBlue;
            this.nmCouchAngle.Location = new System.Drawing.Point(260, 24);
            this.nmCouchAngle.Maximum = new decimal(new int[] {
            660,
            0,
            0,
            0});
            this.nmCouchAngle.Minimum = new decimal(new int[] {
            660,
            0,
            0,
            -2147483648});
            this.nmCouchAngle.Name = "nmCouchAngle";
            this.nmCouchAngle.Size = new System.Drawing.Size(65, 29);
            this.nmCouchAngle.TabIndex = 198;
            this.nmCouchAngle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nmCouchAngle_MouseUp);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.panel6);
            this.groupBox9.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            this.groupBox9.Location = new System.Drawing.Point(48, 143);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(347, 91);
            this.groupBox9.TabIndex = 218;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "治疗床控制";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.nmCouchVrt);
            this.panel6.Controls.Add(this.nmCouchLng);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.nmCouchLat);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.nmCouchAngle);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(341, 69);
            this.panel6.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(279, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 197;
            this.label7.Text = "ANG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(422, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 262;
            this.label12.Text = "Y2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(352, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 14);
            this.label13.TabIndex = 261;
            this.label13.Text = "Y1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.SteelBlue;
            this.label16.Location = new System.Drawing.Point(280, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 14);
            this.label16.TabIndex = 260;
            this.label16.Text = "X2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.SteelBlue;
            this.label18.Location = new System.Drawing.Point(205, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 14);
            this.label18.TabIndex = 259;
            this.label18.Text = "X1";
            // 
            // numY2
            // 
            this.numY2.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numY2.ForeColor = System.Drawing.Color.SteelBlue;
            this.numY2.Location = new System.Drawing.Point(410, 24);
            this.numY2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numY2.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numY2.Name = "numY2";
            this.numY2.Size = new System.Drawing.Size(65, 29);
            this.numY2.TabIndex = 258;
            this.numY2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numX1_MouseUp_1);
            // 
            // numY1
            // 
            this.numY1.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numY1.ForeColor = System.Drawing.Color.SteelBlue;
            this.numY1.Location = new System.Drawing.Point(335, 24);
            this.numY1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numY1.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numY1.Name = "numY1";
            this.numY1.Size = new System.Drawing.Size(65, 29);
            this.numY1.TabIndex = 257;
            this.numY1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numX1_MouseUp_1);
            // 
            // numX2
            // 
            this.numX2.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numX2.ForeColor = System.Drawing.Color.SteelBlue;
            this.numX2.Location = new System.Drawing.Point(260, 24);
            this.numX2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numX2.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numX2.Name = "numX2";
            this.numX2.Size = new System.Drawing.Size(65, 29);
            this.numX2.TabIndex = 256;
            this.numX2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numX1_MouseUp_1);
            // 
            // numX1
            // 
            this.numX1.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numX1.ForeColor = System.Drawing.Color.SteelBlue;
            this.numX1.Location = new System.Drawing.Point(185, 24);
            this.numX1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numX1.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numX1.Name = "numX1";
            this.numX1.Size = new System.Drawing.Size(65, 29);
            this.numX1.TabIndex = 255;
            this.numX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numX1_KeyPress);
            this.numX1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numX1_MouseUp_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gantry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(89, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Collim.";
            // 
            // nmCollAngle
            // 
            this.nmCollAngle.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmCollAngle.ForeColor = System.Drawing.Color.SteelBlue;
            this.nmCollAngle.Location = new System.Drawing.Point(86, 24);
            this.nmCollAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nmCollAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nmCollAngle.Name = "nmCollAngle";
            this.nmCollAngle.Size = new System.Drawing.Size(65, 29);
            this.nmCollAngle.TabIndex = 194;
            this.nmCollAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmCollAngle_KeyPress);
            // 
            // nmGantryAngle
            // 
            this.nmGantryAngle.Font = new System.Drawing.Font("SimHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nmGantryAngle.ForeColor = System.Drawing.Color.SteelBlue;
            this.nmGantryAngle.Location = new System.Drawing.Point(11, 24);
            this.nmGantryAngle.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nmGantryAngle.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nmGantryAngle.Name = "nmGantryAngle";
            this.nmGantryAngle.Size = new System.Drawing.Size(65, 29);
            this.nmGantryAngle.TabIndex = 193;
            this.nmGantryAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmGantryAngle_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.panel5);
            this.groupBox11.Font = new System.Drawing.Font("SimHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            this.groupBox11.Location = new System.Drawing.Point(45, 34);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(541, 94);
            this.groupBox11.TabIndex = 219;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "机头控制";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.numY2);
            this.panel5.Controls.Add(this.numY1);
            this.panel5.Controls.Add(this.numX2);
            this.panel5.Controls.Add(this.numX1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.nmCollAngle);
            this.panel5.Controls.Add(this.nmGantryAngle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 72);
            this.panel5.TabIndex = 218;
            // 
            // buttonBoard
            // 
            this.buttonBoard.Location = new System.Drawing.Point(51, 270);
            this.buttonBoard.Name = "buttonBoard";
            this.buttonBoard.Size = new System.Drawing.Size(91, 43);
            this.buttonBoard.TabIndex = 226;
            this.buttonBoard.Text = "光野验证";
            this.buttonBoard.UseVisualStyleBackColor = true;
            this.buttonBoard.Click += new System.EventHandler(this.buttonBoard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 227;
            this.button1.Text = "MLC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBeamOn
            // 
            this.buttonBeamOn.Location = new System.Drawing.Point(406, 270);
            this.buttonBeamOn.Name = "buttonBeamOn";
            this.buttonBeamOn.Size = new System.Drawing.Size(95, 43);
            this.buttonBeamOn.TabIndex = 228;
            this.buttonBeamOn.Text = "出束";
            this.buttonBeamOn.UseVisualStyleBackColor = true;
            this.buttonBeamOn.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBeamOff
            // 
            this.buttonBeamOff.Location = new System.Drawing.Point(532, 270);
            this.buttonBeamOff.Name = "buttonBeamOff";
            this.buttonBeamOff.Size = new System.Drawing.Size(95, 43);
            this.buttonBeamOff.TabIndex = 229;
            this.buttonBeamOff.Text = "停止出束";
            this.buttonBeamOff.UseVisualStyleBackColor = true;
            this.buttonBeamOff.Click += new System.EventHandler(this.buttonBeamOff_Click);
            // 
            // buttonFieldLight
            // 
            this.buttonFieldLight.Location = new System.Drawing.Point(164, 270);
            this.buttonFieldLight.Name = "buttonFieldLight";
            this.buttonFieldLight.Size = new System.Drawing.Size(91, 43);
            this.buttonFieldLight.TabIndex = 230;
            this.buttonFieldLight.Text = "灯光野";
            this.buttonFieldLight.UseVisualStyleBackColor = true;
            this.buttonFieldLight.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(51, 361);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(91, 38);
            this.buttonQuery.TabIndex = 243;
            this.buttonQuery.Text = "查询状态";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // vrtPlan
            // 
            this.vrtPlan.AccessibleDescription = "";
            this.vrtPlan.AutoSize = true;
            this.vrtPlan.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vrtPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vrtPlan.Location = new System.Drawing.Point(345, 385);
            this.vrtPlan.Name = "vrtPlan";
            this.vrtPlan.Size = new System.Drawing.Size(63, 14);
            this.vrtPlan.TabIndex = 249;
            this.vrtPlan.Text = "No Accy";
            // 
            // collPlan
            // 
            this.collPlan.AutoSize = true;
            this.collPlan.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.collPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.collPlan.Location = new System.Drawing.Point(345, 357);
            this.collPlan.Name = "collPlan";
            this.collPlan.Size = new System.Drawing.Size(63, 14);
            this.collPlan.TabIndex = 248;
            this.collPlan.Text = "No Accy";
            // 
            // gantryPlan
            // 
            this.gantryPlan.AutoSize = true;
            this.gantryPlan.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gantryPlan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gantryPlan.Location = new System.Drawing.Point(345, 337);
            this.gantryPlan.Name = "gantryPlan";
            this.gantryPlan.Size = new System.Drawing.Size(63, 14);
            this.gantryPlan.TabIndex = 247;
            this.gantryPlan.Text = "No Accy";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label47.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label47.Location = new System.Drawing.Point(315, 386);
            this.label47.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(26, 12);
            this.label47.TabIndex = 246;
            this.label47.Text = "Vrt";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label37.Location = new System.Drawing.Point(266, 359);
            this.label37.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(75, 12);
            this.label37.TabIndex = 245;
            this.label37.Text = "Coll Angle";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label36.Location = new System.Drawing.Point(259, 339);
            this.label36.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 12);
            this.label36.TabIndex = 244;
            this.label36.Text = "GantryAngle";
            // 
            // labelStatus
            // 
            this.labelStatus.AccessibleDescription = "";
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStatus.Location = new System.Drawing.Point(345, 427);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(63, 14);
            this.labelStatus.TabIndex = 250;
            this.labelStatus.Text = "No Accy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(312, 429);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 12);
            this.label8.TabIndex = 251;
            this.label8.Text = "状态";
            // 
            // FormDemoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.vrtPlan);
            this.Controls.Add(this.collPlan);
            this.Controls.Add(this.gantryPlan);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonFieldLight);
            this.Controls.Add(this.buttonBeamOff);
            this.Controls.Add(this.buttonBeamOn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBoard);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox11);
            this.Name = "FormDemoMain";
            this.Text = "LinacVR SDK Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDemoMain_FormClosed);
            this.Load += new System.EventHandler(this.FormDemoMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchVrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchLng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCouchAngle)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCollAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGantryAngle)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmCouchVrt;
        private System.Windows.Forms.NumericUpDown nmCouchLng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmCouchLat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmCouchAngle;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numY2;
        private System.Windows.Forms.NumericUpDown numY1;
        private System.Windows.Forms.NumericUpDown numX2;
        private System.Windows.Forms.NumericUpDown numX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmCollAngle;
        private System.Windows.Forms.NumericUpDown nmGantryAngle;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonBoard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBeamOn;
        private System.Windows.Forms.Button buttonBeamOff;
        private System.Windows.Forms.Button buttonFieldLight;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Label vrtPlan;
        private System.Windows.Forms.Label collPlan;
        private System.Windows.Forms.Label gantryPlan;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label8;
    }
}

