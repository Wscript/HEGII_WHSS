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
            this.buttonLocationQuery = new System.Windows.Forms.Button();
            this.textLocationCode = new System.Windows.Forms.TextBox();
            this.labelLocationCode = new System.Windows.Forms.Label();
            this.labelWarehouseName1 = new System.Windows.Forms.Label();
            this.groupLocationChange = new System.Windows.Forms.GroupBox();
            this.labelWarehouseCode = new System.Windows.Forms.Label();
            this.textLocation2End = new System.Windows.Forms.TextBox();
            this.textLocation2Start = new System.Windows.Forms.TextBox();
            this.textLocation1End = new System.Windows.Forms.TextBox();
            this.textLocation1Start = new System.Windows.Forms.TextBox();
            this.textRack2End = new System.Windows.Forms.TextBox();
            this.textRack2Start = new System.Windows.Forms.TextBox();
            this.textRack1End = new System.Windows.Forms.TextBox();
            this.textRack1Start = new System.Windows.Forms.TextBox();
            this.labelEndLocation = new System.Windows.Forms.Label();
            this.labelStartLocation = new System.Windows.Forms.Label();
            this.labelEndLocationLabel = new System.Windows.Forms.Label();
            this.labelStartLocationLabel = new System.Windows.Forms.Label();
            this.labelLocation2 = new System.Windows.Forms.Label();
            this.labelLocation1 = new System.Windows.Forms.Label();
            this.labelRack2 = new System.Windows.Forms.Label();
            this.labelRack1 = new System.Windows.Forms.Label();
            this.labelBarLocation2 = new System.Windows.Forms.Label();
            this.labelBarLocation1 = new System.Windows.Forms.Label();
            this.labelBarRack2 = new System.Windows.Forms.Label();
            this.labelBarRack1 = new System.Windows.Forms.Label();
            this.buttonLocationDelete = new System.Windows.Forms.Button();
            this.buttonLocationAdd = new System.Windows.Forms.Button();
            this.comboWarehouseName2 = new System.Windows.Forms.ComboBox();
            this.labelWarehouseName2 = new System.Windows.Forms.Label();
            this.dataGridLocationList = new System.Windows.Forms.DataGridView();
            this.groupLocationQuery.SuspendLayout();
            this.groupLocationChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocationList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLocationQuery
            // 
            this.groupLocationQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLocationQuery.Controls.Add(this.comboWarehouseName1);
            this.groupLocationQuery.Controls.Add(this.buttonLocationQuery);
            this.groupLocationQuery.Controls.Add(this.textLocationCode);
            this.groupLocationQuery.Controls.Add(this.labelLocationCode);
            this.groupLocationQuery.Controls.Add(this.labelWarehouseName1);
            this.groupLocationQuery.Location = new System.Drawing.Point(14, 14);
            this.groupLocationQuery.Margin = new System.Windows.Forms.Padding(5);
            this.groupLocationQuery.Name = "groupLocationQuery";
            this.groupLocationQuery.Padding = new System.Windows.Forms.Padding(5);
            this.groupLocationQuery.Size = new System.Drawing.Size(779, 77);
            this.groupLocationQuery.TabIndex = 1;
            this.groupLocationQuery.TabStop = false;
            this.groupLocationQuery.Text = "货位查询";
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
            // buttonLocationQuery
            // 
            this.buttonLocationQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLocationQuery.Location = new System.Drawing.Point(650, 26);
            this.buttonLocationQuery.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonLocationQuery.Name = "buttonLocationQuery";
            this.buttonLocationQuery.Size = new System.Drawing.Size(93, 35);
            this.buttonLocationQuery.TabIndex = 16;
            this.buttonLocationQuery.Text = "查询";
            this.buttonLocationQuery.UseVisualStyleBackColor = true;
            this.buttonLocationQuery.Click += new System.EventHandler(this.buttonLocationQuery_Click);
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
            // labelWarehouseName1
            // 
            this.labelWarehouseName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouseName1.AutoSize = true;
            this.labelWarehouseName1.Location = new System.Drawing.Point(18, 33);
            this.labelWarehouseName1.Name = "labelWarehouseName1";
            this.labelWarehouseName1.Size = new System.Drawing.Size(74, 21);
            this.labelWarehouseName1.TabIndex = 0;
            this.labelWarehouseName1.Text = "仓库名称";
            // 
            // groupLocationChange
            // 
            this.groupLocationChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLocationChange.Controls.Add(this.labelWarehouseCode);
            this.groupLocationChange.Controls.Add(this.textLocation2End);
            this.groupLocationChange.Controls.Add(this.textLocation2Start);
            this.groupLocationChange.Controls.Add(this.textLocation1End);
            this.groupLocationChange.Controls.Add(this.textLocation1Start);
            this.groupLocationChange.Controls.Add(this.textRack2End);
            this.groupLocationChange.Controls.Add(this.textRack2Start);
            this.groupLocationChange.Controls.Add(this.textRack1End);
            this.groupLocationChange.Controls.Add(this.textRack1Start);
            this.groupLocationChange.Controls.Add(this.labelEndLocation);
            this.groupLocationChange.Controls.Add(this.labelStartLocation);
            this.groupLocationChange.Controls.Add(this.labelEndLocationLabel);
            this.groupLocationChange.Controls.Add(this.labelStartLocationLabel);
            this.groupLocationChange.Controls.Add(this.labelLocation2);
            this.groupLocationChange.Controls.Add(this.labelLocation1);
            this.groupLocationChange.Controls.Add(this.labelRack2);
            this.groupLocationChange.Controls.Add(this.labelRack1);
            this.groupLocationChange.Controls.Add(this.labelBarLocation2);
            this.groupLocationChange.Controls.Add(this.labelBarLocation1);
            this.groupLocationChange.Controls.Add(this.labelBarRack2);
            this.groupLocationChange.Controls.Add(this.labelBarRack1);
            this.groupLocationChange.Controls.Add(this.buttonLocationDelete);
            this.groupLocationChange.Controls.Add(this.buttonLocationAdd);
            this.groupLocationChange.Controls.Add(this.comboWarehouseName2);
            this.groupLocationChange.Controls.Add(this.labelWarehouseName2);
            this.groupLocationChange.Location = new System.Drawing.Point(16, 414);
            this.groupLocationChange.Name = "groupLocationChange";
            this.groupLocationChange.Size = new System.Drawing.Size(779, 148);
            this.groupLocationChange.TabIndex = 2;
            this.groupLocationChange.TabStop = false;
            this.groupLocationChange.Text = "货位增加/删除";
            // 
            // labelWarehouseCode
            // 
            this.labelWarehouseCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouseCode.AutoSize = true;
            this.labelWarehouseCode.Location = new System.Drawing.Point(471, 33);
            this.labelWarehouseCode.Name = "labelWarehouseCode";
            this.labelWarehouseCode.Size = new System.Drawing.Size(0, 21);
            this.labelWarehouseCode.TabIndex = 52;
            this.labelWarehouseCode.Visible = false;
            // 
            // textLocation2End
            // 
            this.textLocation2End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLocation2End.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLocation2End.Location = new System.Drawing.Point(392, 104);
            this.textLocation2End.MaxLength = 1;
            this.textLocation2End.Name = "textLocation2End";
            this.textLocation2End.Size = new System.Drawing.Size(42, 29);
            this.textLocation2End.TabIndex = 50;
            this.textLocation2End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLocation2End.TextChanged += new System.EventHandler(this.textLocation2End_TextChanged);
            // 
            // textLocation2Start
            // 
            this.textLocation2Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLocation2Start.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLocation2Start.Location = new System.Drawing.Point(321, 104);
            this.textLocation2Start.MaxLength = 1;
            this.textLocation2Start.Name = "textLocation2Start";
            this.textLocation2Start.Size = new System.Drawing.Size(42, 29);
            this.textLocation2Start.TabIndex = 49;
            this.textLocation2Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLocation2Start.TextChanged += new System.EventHandler(this.textLocation2Start_TextChanged);
            // 
            // textLocation1End
            // 
            this.textLocation1End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLocation1End.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLocation1End.Location = new System.Drawing.Point(392, 69);
            this.textLocation1End.MaxLength = 1;
            this.textLocation1End.Name = "textLocation1End";
            this.textLocation1End.Size = new System.Drawing.Size(42, 29);
            this.textLocation1End.TabIndex = 48;
            this.textLocation1End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLocation1End.TextChanged += new System.EventHandler(this.textLocation1End_TextChanged);
            // 
            // textLocation1Start
            // 
            this.textLocation1Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLocation1Start.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLocation1Start.Location = new System.Drawing.Point(321, 69);
            this.textLocation1Start.MaxLength = 1;
            this.textLocation1Start.Name = "textLocation1Start";
            this.textLocation1Start.Size = new System.Drawing.Size(42, 29);
            this.textLocation1Start.TabIndex = 47;
            this.textLocation1Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLocation1Start.TextChanged += new System.EventHandler(this.textLocation1Start_TextChanged);
            // 
            // textRack2End
            // 
            this.textRack2End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRack2End.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRack2End.Location = new System.Drawing.Point(167, 104);
            this.textRack2End.MaxLength = 1;
            this.textRack2End.Name = "textRack2End";
            this.textRack2End.Size = new System.Drawing.Size(42, 29);
            this.textRack2End.TabIndex = 46;
            this.textRack2End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRack2End.TextChanged += new System.EventHandler(this.textRack2End_TextChanged);
            // 
            // textRack2Start
            // 
            this.textRack2Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRack2Start.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRack2Start.Location = new System.Drawing.Point(96, 104);
            this.textRack2Start.MaxLength = 1;
            this.textRack2Start.Name = "textRack2Start";
            this.textRack2Start.Size = new System.Drawing.Size(42, 29);
            this.textRack2Start.TabIndex = 45;
            this.textRack2Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRack2Start.TextChanged += new System.EventHandler(this.textRack2Start_TextChanged);
            // 
            // textRack1End
            // 
            this.textRack1End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRack1End.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRack1End.Location = new System.Drawing.Point(167, 69);
            this.textRack1End.MaxLength = 1;
            this.textRack1End.Name = "textRack1End";
            this.textRack1End.Size = new System.Drawing.Size(42, 29);
            this.textRack1End.TabIndex = 44;
            this.textRack1End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRack1End.TextChanged += new System.EventHandler(this.textRack1End_TextChanged);
            // 
            // textRack1Start
            // 
            this.textRack1Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRack1Start.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRack1Start.Location = new System.Drawing.Point(96, 69);
            this.textRack1Start.MaxLength = 1;
            this.textRack1Start.Name = "textRack1Start";
            this.textRack1Start.Size = new System.Drawing.Size(42, 29);
            this.textRack1Start.TabIndex = 43;
            this.textRack1Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRack1Start.TextChanged += new System.EventHandler(this.textRack1Start_TextChanged);
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
            this.labelLocation1.Location = new System.Drawing.Point(240, 72);
            this.labelLocation1.Name = "labelLocation1";
            this.labelLocation1.Size = new System.Drawing.Size(67, 21);
            this.labelLocation1.TabIndex = 37;
            this.labelLocation1.Text = "货位号1";
            // 
            // labelRack2
            // 
            this.labelRack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRack2.AutoSize = true;
            this.labelRack2.Location = new System.Drawing.Point(18, 107);
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
            // labelBarLocation2
            // 
            this.labelBarLocation2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarLocation2.AutoSize = true;
            this.labelBarLocation2.Location = new System.Drawing.Point(369, 107);
            this.labelBarLocation2.Name = "labelBarLocation2";
            this.labelBarLocation2.Size = new System.Drawing.Size(17, 21);
            this.labelBarLocation2.TabIndex = 34;
            this.labelBarLocation2.Text = "-";
            this.labelBarLocation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBarLocation1
            // 
            this.labelBarLocation1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarLocation1.AutoSize = true;
            this.labelBarLocation1.Location = new System.Drawing.Point(369, 72);
            this.labelBarLocation1.Name = "labelBarLocation1";
            this.labelBarLocation1.Size = new System.Drawing.Size(17, 21);
            this.labelBarLocation1.TabIndex = 31;
            this.labelBarLocation1.Text = "-";
            this.labelBarLocation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBarRack2
            // 
            this.labelBarRack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarRack2.AutoSize = true;
            this.labelBarRack2.Location = new System.Drawing.Point(144, 107);
            this.labelBarRack2.Name = "labelBarRack2";
            this.labelBarRack2.Size = new System.Drawing.Size(17, 21);
            this.labelBarRack2.TabIndex = 28;
            this.labelBarRack2.Text = "-";
            this.labelBarRack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBarRack1
            // 
            this.labelBarRack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBarRack1.AutoSize = true;
            this.labelBarRack1.Location = new System.Drawing.Point(144, 70);
            this.labelBarRack1.Name = "labelBarRack1";
            this.labelBarRack1.Size = new System.Drawing.Size(17, 21);
            this.labelBarRack1.TabIndex = 25;
            this.labelBarRack1.Text = "-";
            this.labelBarRack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonLocationDelete.Click += new System.EventHandler(this.buttonLocationDelete_Click);
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
            // labelWarehouseName2
            // 
            this.labelWarehouseName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouseName2.AutoSize = true;
            this.labelWarehouseName2.Location = new System.Drawing.Point(15, 33);
            this.labelWarehouseName2.Name = "labelWarehouseName2";
            this.labelWarehouseName2.Size = new System.Drawing.Size(74, 21);
            this.labelWarehouseName2.TabIndex = 18;
            this.labelWarehouseName2.Text = "仓库名称";
            // 
            // dataGridLocationList
            // 
            this.dataGridLocationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLocationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocationList.Location = new System.Drawing.Point(16, 103);
            this.dataGridLocationList.Name = "dataGridLocationList";
            this.dataGridLocationList.RowTemplate.Height = 23;
            this.dataGridLocationList.Size = new System.Drawing.Size(779, 305);
            this.dataGridLocationList.TabIndex = 3;
            // 
            // formLocationMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 573);
            this.Controls.Add(this.dataGridLocationList);
            this.Controls.Add(this.groupLocationChange);
            this.Controls.Add(this.groupLocationQuery);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formLocationMgt";
            this.Text = "货位管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLocationMgt_FormClosing);
            this.Load += new System.EventHandler(this.formLocationMgt_Load);
            this.groupLocationQuery.ResumeLayout(false);
            this.groupLocationQuery.PerformLayout();
            this.groupLocationChange.ResumeLayout(false);
            this.groupLocationChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLocationQuery;
        private System.Windows.Forms.Button buttonLocationQuery;
        private System.Windows.Forms.TextBox textLocationCode;
        private System.Windows.Forms.Label labelLocationCode;
        private System.Windows.Forms.Label labelWarehouseName1;
        private System.Windows.Forms.GroupBox groupLocationChange;
        private System.Windows.Forms.DataGridView dataGridLocationList;
        private System.Windows.Forms.ComboBox comboWarehouseName1;
        private System.Windows.Forms.Button buttonLocationDelete;
        private System.Windows.Forms.Button buttonLocationAdd;
        private System.Windows.Forms.ComboBox comboWarehouseName2;
        private System.Windows.Forms.Label labelWarehouseName2;
        private System.Windows.Forms.Label labelStartLocationLabel;
        private System.Windows.Forms.Label labelLocation2;
        private System.Windows.Forms.Label labelLocation1;
        private System.Windows.Forms.Label labelRack2;
        private System.Windows.Forms.Label labelRack1;
        private System.Windows.Forms.Label labelBarLocation2;
        private System.Windows.Forms.Label labelBarLocation1;
        private System.Windows.Forms.Label labelBarRack2;
        private System.Windows.Forms.Label labelBarRack1;
        private System.Windows.Forms.Label labelEndLocationLabel;
        private System.Windows.Forms.Label labelEndLocation;
        private System.Windows.Forms.Label labelStartLocation;
        private System.Windows.Forms.TextBox textLocation2End;
        private System.Windows.Forms.TextBox textLocation2Start;
        private System.Windows.Forms.TextBox textLocation1End;
        private System.Windows.Forms.TextBox textLocation1Start;
        private System.Windows.Forms.TextBox textRack2End;
        private System.Windows.Forms.TextBox textRack2Start;
        private System.Windows.Forms.TextBox textRack1End;
        private System.Windows.Forms.TextBox textRack1Start;
        private System.Windows.Forms.Label labelWarehouseCode;
    }
}