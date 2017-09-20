namespace HEGII_WHSS
{
    partial class formLocationMgt
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
            this.groupLocationQuery = new System.Windows.Forms.GroupBox();
            this.comboWarehouseName1 = new System.Windows.Forms.ComboBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textLocationCode = new System.Windows.Forms.TextBox();
            this.labelLocationCode = new System.Windows.Forms.Label();
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.groupLocationChange = new System.Windows.Forms.GroupBox();
            this.labelEndLocation = new System.Windows.Forms.Label();
            this.labelStartLocation = new System.Windows.Forms.Label();
            this.labelEndLocationLabel = new System.Windows.Forms.Label();
            this.labelStartLocationLabel = new System.Windows.Forms.Label();
            this.labelLocation2 = new System.Windows.Forms.Label();
            this.labelLocation1 = new System.Windows.Forms.Label();
            this.labelRack2 = new System.Windows.Forms.Label();
            this.labelRack1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLocation2End = new System.Windows.Forms.ComboBox();
            this.comboLocation2Start = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboLocation1End = new System.Windows.Forms.ComboBox();
            this.comboLocation1Start = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRack2End = new System.Windows.Forms.ComboBox();
            this.comboRack2Start = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRack1End = new System.Windows.Forms.ComboBox();
            this.comboRack1Start = new System.Windows.Forms.ComboBox();
            this.buttonLocationDelete = new System.Windows.Forms.Button();
            this.buttonLocationAdd = new System.Windows.Forms.Button();
            this.comboWarehouseName2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupLocationQuery.SuspendLayout();
            this.groupLocationChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLocationQuery
            // 
            this.groupLocationQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLocationQuery.Controls.Add(this.comboWarehouseName1);
            this.groupLocationQuery.Controls.Add(this.buttonQuery);
            this.groupLocationQuery.Controls.Add(this.textLocationCode);
            this.groupLocationQuery.Controls.Add(this.labelLocationCode);
            this.groupLocationQuery.Controls.Add(this.labelWarehouseName);
            this.groupLocationQuery.Location = new System.Drawing.Point(14, 14);
            this.groupLocationQuery.Margin = new System.Windows.Forms.Padding(5);
            this.groupLocationQuery.Name = "groupLocationQuery";
            this.groupLocationQuery.Padding = new System.Windows.Forms.Padding(5);
            this.groupLocationQuery.Size = new System.Drawing.Size(779, 77);
            this.groupLocationQuery.TabIndex = 1;
            this.groupLocationQuery.TabStop = false;
            this.groupLocationQuery.Text = "仓库查询";
            // 
            // comboWarehouseName1
            // 
            this.comboWarehouseName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboWarehouseName1.FormattingEnabled = true;
            this.comboWarehouseName1.Location = new System.Drawing.Point(98, 30);
            this.comboWarehouseName1.Name = "comboWarehouseName1";
            this.comboWarehouseName1.Size = new System.Drawing.Size(214, 29);
            this.comboWarehouseName1.TabIndex = 17;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuery.Location = new System.Drawing.Point(650, 26);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(93, 35);
            this.buttonQuery.TabIndex = 16;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            // 
            // textLocationCode
            // 
            this.textLocationCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLocationCode.Location = new System.Drawing.Point(416, 30);
            this.textLocationCode.Name = "textLocationCode";
            this.textLocationCode.Size = new System.Drawing.Size(211, 29);
            this.textLocationCode.TabIndex = 3;
            // 
            // labelLocationCode
            // 
            this.labelLocationCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocationCode.AutoSize = true;
            this.labelLocationCode.Location = new System.Drawing.Point(336, 33);
            this.labelLocationCode.Name = "labelLocationCode";
            this.labelLocationCode.Size = new System.Drawing.Size(74, 21);
            this.labelLocationCode.TabIndex = 2;
            this.labelLocationCode.Text = "货位编码";
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.Location = new System.Drawing.Point(18, 33);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(74, 21);
            this.labelWarehouseName.TabIndex = 0;
            this.labelWarehouseName.Text = "仓库名称";
            // 
            // groupLocationChange
            // 
            this.groupLocationChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLocationChange.Controls.Add(this.labelEndLocation);
            this.groupLocationChange.Controls.Add(this.labelStartLocation);
            this.groupLocationChange.Controls.Add(this.labelEndLocationLabel);
            this.groupLocationChange.Controls.Add(this.labelStartLocationLabel);
            this.groupLocationChange.Controls.Add(this.labelLocation2);
            this.groupLocationChange.Controls.Add(this.labelLocation1);
            this.groupLocationChange.Controls.Add(this.labelRack2);
            this.groupLocationChange.Controls.Add(this.labelRack1);
            this.groupLocationChange.Controls.Add(this.label5);
            this.groupLocationChange.Controls.Add(this.comboLocation2End);
            this.groupLocationChange.Controls.Add(this.comboLocation2Start);
            this.groupLocationChange.Controls.Add(this.label4);
            this.groupLocationChange.Controls.Add(this.comboLocation1End);
            this.groupLocationChange.Controls.Add(this.comboLocation1Start);
            this.groupLocationChange.Controls.Add(this.label3);
            this.groupLocationChange.Controls.Add(this.comboRack2End);
            this.groupLocationChange.Controls.Add(this.comboRack2Start);
            this.groupLocationChange.Controls.Add(this.label2);
            this.groupLocationChange.Controls.Add(this.comboRack1End);
            this.groupLocationChange.Controls.Add(this.comboRack1Start);
            this.groupLocationChange.Controls.Add(this.buttonLocationDelete);
            this.groupLocationChange.Controls.Add(this.buttonLocationAdd);
            this.groupLocationChange.Controls.Add(this.comboWarehouseName2);
            this.groupLocationChange.Controls.Add(this.label1);
            this.groupLocationChange.Location = new System.Drawing.Point(16, 414);
            this.groupLocationChange.Name = "groupLocationChange";
            this.groupLocationChange.Size = new System.Drawing.Size(779, 148);
            this.groupLocationChange.TabIndex = 2;
            this.groupLocationChange.TabStop = false;
            this.groupLocationChange.Text = "货位增加/删除";
            // 
            // labelEndLocation
            // 
            this.labelEndLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndLocation.AutoSize = true;
            this.labelEndLocation.Location = new System.Drawing.Point(551, 107);
            this.labelEndLocation.Name = "labelEndLocation";
            this.labelEndLocation.Size = new System.Drawing.Size(74, 21);
            this.labelEndLocation.TabIndex = 42;
            this.labelEndLocation.Text = "起始货位";
            // 
            // labelStartLocation
            // 
            this.labelStartLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStartLocation.AutoSize = true;
            this.labelStartLocation.Location = new System.Drawing.Point(551, 70);
            this.labelStartLocation.Name = "labelStartLocation";
            this.labelStartLocation.Size = new System.Drawing.Size(74, 21);
            this.labelStartLocation.TabIndex = 41;
            this.labelStartLocation.Text = "起始货位";
            // 
            // labelEndLocationLabel
            // 
            this.labelEndLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndLocationLabel.AutoSize = true;
            this.labelEndLocationLabel.Location = new System.Drawing.Point(471, 107);
            this.labelEndLocationLabel.Name = "labelEndLocationLabel";
            this.labelEndLocationLabel.Size = new System.Drawing.Size(74, 21);
            this.labelEndLocationLabel.TabIndex = 40;
            this.labelEndLocationLabel.Text = "结束货位";
            // 
            // labelStartLocationLabel
            // 
            this.labelStartLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStartLocationLabel.AutoSize = true;
            this.labelStartLocationLabel.Location = new System.Drawing.Point(471, 70);
            this.labelStartLocationLabel.Name = "labelStartLocationLabel";
            this.labelStartLocationLabel.Size = new System.Drawing.Size(74, 21);
            this.labelStartLocationLabel.TabIndex = 39;
            this.labelStartLocationLabel.Text = "起始货位";
            // 
            // labelLocation2
            // 
            this.labelLocation2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocation2.AutoSize = true;
            this.labelLocation2.Location = new System.Drawing.Point(242, 107);
            this.labelLocation2.Name = "labelLocation2";
            this.labelLocation2.Size = new System.Drawing.Size(67, 21);
            this.labelLocation2.TabIndex = 38;
            this.labelLocation2.Text = "货位号2";
            // 
            // labelLocation1
            // 
            this.labelLocation1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocation1.AutoSize = true;
            this.labelLocation1.Location = new System.Drawing.Point(15, 107);
            this.labelLocation1.Name = "labelLocation1";
            this.labelLocation1.Size = new System.Drawing.Size(67, 21);
            this.labelLocation1.TabIndex = 37;
            this.labelLocation1.Text = "货位号1";
            // 
            // labelRack2
            // 
            this.labelRack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRack2.AutoSize = true;
            this.labelRack2.Location = new System.Drawing.Point(243, 70);
            this.labelRack2.Name = "labelRack2";
            this.labelRack2.Size = new System.Drawing.Size(67, 21);
            this.labelRack2.TabIndex = 36;
            this.labelRack2.Text = "货架号2";
            // 
            // labelRack1
            // 
            this.labelRack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRack1.AutoSize = true;
            this.labelRack1.Location = new System.Drawing.Point(15, 70);
            this.labelRack1.Name = "labelRack1";
            this.labelRack1.Size = new System.Drawing.Size(67, 21);
            this.labelRack1.TabIndex = 35;
            this.labelRack1.Text = "货架号1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboLocation2End
            // 
            this.comboLocation2End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLocation2End.FormattingEnabled = true;
            this.comboLocation2End.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboLocation2End.Location = new System.Drawing.Point(392, 103);
            this.comboLocation2End.Name = "comboLocation2End";
            this.comboLocation2End.Size = new System.Drawing.Size(43, 29);
            this.comboLocation2End.TabIndex = 33;
            this.comboLocation2End.SelectedIndexChanged += new System.EventHandler(this.comboLocation2End_SelectedIndexChanged);
            // 
            // comboLocation2Start
            // 
            this.comboLocation2Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLocation2Start.FormattingEnabled = true;
            this.comboLocation2Start.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboLocation2Start.Location = new System.Drawing.Point(320, 103);
            this.comboLocation2Start.Name = "comboLocation2Start";
            this.comboLocation2Start.Size = new System.Drawing.Size(43, 29);
            this.comboLocation2Start.TabIndex = 32;
            this.comboLocation2Start.SelectedIndexChanged += new System.EventHandler(this.comboLocation2Start_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboLocation1End
            // 
            this.comboLocation1End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLocation1End.FormattingEnabled = true;
            this.comboLocation1End.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboLocation1End.Location = new System.Drawing.Point(167, 103);
            this.comboLocation1End.Name = "comboLocation1End";
            this.comboLocation1End.Size = new System.Drawing.Size(43, 29);
            this.comboLocation1End.TabIndex = 30;
            this.comboLocation1End.SelectedIndexChanged += new System.EventHandler(this.comboLocation1End_SelectedIndexChanged);
            // 
            // comboLocation1Start
            // 
            this.comboLocation1Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLocation1Start.FormattingEnabled = true;
            this.comboLocation1Start.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboLocation1Start.Location = new System.Drawing.Point(95, 103);
            this.comboLocation1Start.Name = "comboLocation1Start";
            this.comboLocation1Start.Size = new System.Drawing.Size(43, 29);
            this.comboLocation1Start.TabIndex = 29;
            this.comboLocation1Start.SelectedIndexChanged += new System.EventHandler(this.comboLocation1Start_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboRack2End
            // 
            this.comboRack2End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRack2End.FormattingEnabled = true;
            this.comboRack2End.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboRack2End.Location = new System.Drawing.Point(392, 66);
            this.comboRack2End.Name = "comboRack2End";
            this.comboRack2End.Size = new System.Drawing.Size(43, 29);
            this.comboRack2End.TabIndex = 27;
            this.comboRack2End.SelectedIndexChanged += new System.EventHandler(this.comboRack2End_SelectedIndexChanged);
            // 
            // comboRack2Start
            // 
            this.comboRack2Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRack2Start.FormattingEnabled = true;
            this.comboRack2Start.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboRack2Start.Location = new System.Drawing.Point(320, 66);
            this.comboRack2Start.Name = "comboRack2Start";
            this.comboRack2Start.Size = new System.Drawing.Size(43, 29);
            this.comboRack2Start.TabIndex = 26;
            this.comboRack2Start.SelectedIndexChanged += new System.EventHandler(this.comboRack2Start_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboRack1End
            // 
            this.comboRack1End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRack1End.FormattingEnabled = true;
            this.comboRack1End.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboRack1End.Location = new System.Drawing.Point(167, 66);
            this.comboRack1End.Name = "comboRack1End";
            this.comboRack1End.Size = new System.Drawing.Size(43, 29);
            this.comboRack1End.TabIndex = 24;
            this.comboRack1End.SelectedIndexChanged += new System.EventHandler(this.comboRack1End_SelectedIndexChanged);
            // 
            // comboRack1Start
            // 
            this.comboRack1Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRack1Start.FormattingEnabled = true;
            this.comboRack1Start.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboRack1Start.Location = new System.Drawing.Point(95, 66);
            this.comboRack1Start.Name = "comboRack1Start";
            this.comboRack1Start.Size = new System.Drawing.Size(43, 29);
            this.comboRack1Start.TabIndex = 23;
            this.comboRack1Start.SelectedIndexChanged += new System.EventHandler(this.comboRack1Start_SelectedIndexChanged);
            // 
            // buttonLocationDelete
            // 
            this.buttonLocationDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLocationDelete.Location = new System.Drawing.Point(675, 100);
            this.buttonLocationDelete.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonLocationDelete.Name = "buttonLocationDelete";
            this.buttonLocationDelete.Size = new System.Drawing.Size(93, 35);
            this.buttonLocationDelete.TabIndex = 22;
            this.buttonLocationDelete.Text = "货位删除";
            this.buttonLocationDelete.UseVisualStyleBackColor = true;
            // 
            // buttonLocationAdd
            // 
            this.buttonLocationAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLocationAdd.Location = new System.Drawing.Point(675, 56);
            this.buttonLocationAdd.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonLocationAdd.Name = "buttonLocationAdd";
            this.buttonLocationAdd.Size = new System.Drawing.Size(93, 35);
            this.buttonLocationAdd.TabIndex = 21;
            this.buttonLocationAdd.Text = "货位增加";
            this.buttonLocationAdd.UseVisualStyleBackColor = true;
            this.buttonLocationAdd.Click += new System.EventHandler(this.buttonLocationAdd_Click);
            // 
            // comboWarehouseName2
            // 
            this.comboWarehouseName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboWarehouseName2.FormattingEnabled = true;
            this.comboWarehouseName2.Location = new System.Drawing.Point(95, 30);
            this.comboWarehouseName2.Name = "comboWarehouseName2";
            this.comboWarehouseName2.Size = new System.Drawing.Size(214, 29);
            this.comboWarehouseName2.TabIndex = 19;
            this.comboWarehouseName2.SelectedIndexChanged += new System.EventHandler(this.comboWarehouseName2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "仓库名称";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(779, 305);
            this.dataGridView1.TabIndex = 3;
            // 
            // formLocationMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupLocationChange);
            this.Controls.Add(this.groupLocationQuery);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formLocationMgt";
            this.Text = "货位管理";
            this.Load += new System.EventHandler(this.formLocationMgt_Load);
            this.groupLocationQuery.ResumeLayout(false);
            this.groupLocationQuery.PerformLayout();
            this.groupLocationChange.ResumeLayout(false);
            this.groupLocationChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLocationQuery;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textLocationCode;
        private System.Windows.Forms.Label labelLocationCode;
        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.GroupBox groupLocationChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboWarehouseName1;
        private System.Windows.Forms.ComboBox comboRack1Start;
        private System.Windows.Forms.Button buttonLocationDelete;
        private System.Windows.Forms.Button buttonLocationAdd;
        private System.Windows.Forms.ComboBox comboWarehouseName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStartLocationLabel;
        private System.Windows.Forms.Label labelLocation2;
        private System.Windows.Forms.Label labelLocation1;
        private System.Windows.Forms.Label labelRack2;
        private System.Windows.Forms.Label labelRack1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLocation2End;
        private System.Windows.Forms.ComboBox comboLocation2Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboLocation1End;
        private System.Windows.Forms.ComboBox comboLocation1Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRack2End;
        private System.Windows.Forms.ComboBox comboRack2Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRack1End;
        private System.Windows.Forms.Label labelEndLocationLabel;
        private System.Windows.Forms.Label labelEndLocation;
        private System.Windows.Forms.Label labelStartLocation;
    }
}