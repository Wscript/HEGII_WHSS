namespace HEGII_WHSS
{
    partial class formOrderQuery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textCustAddress = new System.Windows.Forms.TextBox();
            this.labelCustAddress = new System.Windows.Forms.Label();
            this.comboEngineerList = new System.Windows.Forms.ComboBox();
            this.labelEngineer = new System.Windows.Forms.Label();
            this.textCustPhone = new System.Windows.Forms.TextBox();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.dateTimeReserveEnd = new System.Windows.Forms.DateTimePicker();
            this.comboStoreCategory = new System.Windows.Forms.ComboBox();
            this.labelStoreCategory = new System.Windows.Forms.Label();
            this.dateTimeReserveStart = new System.Windows.Forms.DateTimePicker();
            this.labelReserveDate = new System.Windows.Forms.Label();
            this.groupOrderQuery = new System.Windows.Forms.GroupBox();
            this.comboStoreList = new System.Windows.Forms.ComboBox();
            this.labelStoreList = new System.Windows.Forms.Label();
            this.dataGridOrderList = new System.Windows.Forms.DataGridView();
            this.groupOrderQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(14, 499);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(797, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonQuery.Location = new System.Drawing.Point(686, 109);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(93, 35);
            this.buttonQuery.TabIndex = 14;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textCustAddress
            // 
            this.textCustAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCustAddress.Location = new System.Drawing.Point(407, 67);
            this.textCustAddress.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.textCustAddress.Multiline = true;
            this.textCustAddress.Name = "textCustAddress";
            this.textCustAddress.Size = new System.Drawing.Size(372, 29);
            this.textCustAddress.TabIndex = 13;
            // 
            // labelCustAddress
            // 
            this.labelCustAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCustAddress.AutoSize = true;
            this.labelCustAddress.Location = new System.Drawing.Point(317, 71);
            this.labelCustAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCustAddress.Name = "labelCustAddress";
            this.labelCustAddress.Size = new System.Drawing.Size(74, 21);
            this.labelCustAddress.TabIndex = 12;
            this.labelCustAddress.Text = "客户地址";
            // 
            // comboEngineerList
            // 
            this.comboEngineerList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboEngineerList.FormattingEnabled = true;
            this.comboEngineerList.Location = new System.Drawing.Point(122, 28);
            this.comboEngineerList.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.comboEngineerList.Name = "comboEngineerList";
            this.comboEngineerList.Size = new System.Drawing.Size(179, 29);
            this.comboEngineerList.TabIndex = 11;
            // 
            // labelEngineer
            // 
            this.labelEngineer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEngineer.AutoSize = true;
            this.labelEngineer.Location = new System.Drawing.Point(16, 32);
            this.labelEngineer.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelEngineer.Name = "labelEngineer";
            this.labelEngineer.Size = new System.Drawing.Size(90, 21);
            this.labelEngineer.TabIndex = 10;
            this.labelEngineer.Text = "售后工程师";
            // 
            // textCustPhone
            // 
            this.textCustPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCustPhone.Location = new System.Drawing.Point(407, 112);
            this.textCustPhone.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.textCustPhone.Name = "textCustPhone";
            this.textCustPhone.Size = new System.Drawing.Size(179, 29);
            this.textCustPhone.TabIndex = 9;
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Location = new System.Drawing.Point(317, 116);
            this.labelCustPhone.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(74, 21);
            this.labelCustPhone.TabIndex = 8;
            this.labelCustPhone.Text = "客户电话";
            // 
            // dateTimeReserveEnd
            // 
            this.dateTimeReserveEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeReserveEnd.Location = new System.Drawing.Point(601, 25);
            this.dateTimeReserveEnd.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dateTimeReserveEnd.Name = "dateTimeReserveEnd";
            this.dateTimeReserveEnd.Size = new System.Drawing.Size(178, 29);
            this.dateTimeReserveEnd.TabIndex = 7;
            // 
            // comboStoreCategory
            // 
            this.comboStoreCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboStoreCategory.FormattingEnabled = true;
            this.comboStoreCategory.Location = new System.Drawing.Point(122, 70);
            this.comboStoreCategory.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.comboStoreCategory.Name = "comboStoreCategory";
            this.comboStoreCategory.Size = new System.Drawing.Size(179, 29);
            this.comboStoreCategory.TabIndex = 5;
            this.comboStoreCategory.SelectedIndexChanged += new System.EventHandler(this.comboStoreCategory_SelectedIndexChanged);
            // 
            // labelStoreCategory
            // 
            this.labelStoreCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStoreCategory.AutoSize = true;
            this.labelStoreCategory.Location = new System.Drawing.Point(16, 74);
            this.labelStoreCategory.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStoreCategory.Name = "labelStoreCategory";
            this.labelStoreCategory.Size = new System.Drawing.Size(74, 21);
            this.labelStoreCategory.TabIndex = 4;
            this.labelStoreCategory.Text = "门店类别";
            // 
            // dateTimeReserveStart
            // 
            this.dateTimeReserveStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeReserveStart.Location = new System.Drawing.Point(407, 25);
            this.dateTimeReserveStart.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dateTimeReserveStart.Name = "dateTimeReserveStart";
            this.dateTimeReserveStart.Size = new System.Drawing.Size(178, 29);
            this.dateTimeReserveStart.TabIndex = 3;
            // 
            // labelReserveDate
            // 
            this.labelReserveDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelReserveDate.AutoSize = true;
            this.labelReserveDate.Location = new System.Drawing.Point(317, 32);
            this.labelReserveDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelReserveDate.Name = "labelReserveDate";
            this.labelReserveDate.Size = new System.Drawing.Size(74, 21);
            this.labelReserveDate.TabIndex = 2;
            this.labelReserveDate.Text = "预约日期";
            // 
            // groupOrderQuery
            // 
            this.groupOrderQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOrderQuery.Controls.Add(this.comboStoreList);
            this.groupOrderQuery.Controls.Add(this.labelStoreList);
            this.groupOrderQuery.Controls.Add(this.buttonQuery);
            this.groupOrderQuery.Controls.Add(this.textCustAddress);
            this.groupOrderQuery.Controls.Add(this.labelCustAddress);
            this.groupOrderQuery.Controls.Add(this.comboEngineerList);
            this.groupOrderQuery.Controls.Add(this.labelEngineer);
            this.groupOrderQuery.Controls.Add(this.textCustPhone);
            this.groupOrderQuery.Controls.Add(this.labelCustPhone);
            this.groupOrderQuery.Controls.Add(this.dateTimeReserveEnd);
            this.groupOrderQuery.Controls.Add(this.comboStoreCategory);
            this.groupOrderQuery.Controls.Add(this.labelStoreCategory);
            this.groupOrderQuery.Controls.Add(this.dateTimeReserveStart);
            this.groupOrderQuery.Controls.Add(this.labelReserveDate);
            this.groupOrderQuery.Location = new System.Drawing.Point(17, 19);
            this.groupOrderQuery.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.groupOrderQuery.Name = "groupOrderQuery";
            this.groupOrderQuery.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.groupOrderQuery.Size = new System.Drawing.Size(794, 157);
            this.groupOrderQuery.TabIndex = 4;
            this.groupOrderQuery.TabStop = false;
            this.groupOrderQuery.Text = "订单查询";
            // 
            // comboStoreList
            // 
            this.comboStoreList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboStoreList.FormattingEnabled = true;
            this.comboStoreList.Location = new System.Drawing.Point(122, 112);
            this.comboStoreList.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.comboStoreList.Name = "comboStoreList";
            this.comboStoreList.Size = new System.Drawing.Size(179, 29);
            this.comboStoreList.TabIndex = 18;
            // 
            // labelStoreList
            // 
            this.labelStoreList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStoreList.AutoSize = true;
            this.labelStoreList.Location = new System.Drawing.Point(16, 116);
            this.labelStoreList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStoreList.Name = "labelStoreList";
            this.labelStoreList.Size = new System.Drawing.Size(74, 21);
            this.labelStoreList.TabIndex = 17;
            this.labelStoreList.Text = "销售店面";
            // 
            // dataGridOrderList
            // 
            this.dataGridOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderList.Location = new System.Drawing.Point(17, 196);
            this.dataGridOrderList.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dataGridOrderList.Name = "dataGridOrderList";
            this.dataGridOrderList.RowTemplate.Height = 23;
            this.dataGridOrderList.Size = new System.Drawing.Size(794, 288);
            this.dataGridOrderList.TabIndex = 3;
            // 
            // formOrderQuery
            // 
            this.AcceptButton = this.buttonQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupOrderQuery);
            this.Controls.Add(this.dataGridOrderList);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formOrderQuery";
            this.Text = "订单查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formOrderQuery_FormClosing);
            this.Load += new System.EventHandler(this.formOrderQuery_Load);
            this.groupOrderQuery.ResumeLayout(false);
            this.groupOrderQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textCustAddress;
        private System.Windows.Forms.Label labelCustAddress;
        private System.Windows.Forms.ComboBox comboEngineerList;
        private System.Windows.Forms.Label labelEngineer;
        private System.Windows.Forms.TextBox textCustPhone;
        private System.Windows.Forms.Label labelCustPhone;
        private System.Windows.Forms.DateTimePicker dateTimeReserveEnd;
        private System.Windows.Forms.ComboBox comboStoreCategory;
        private System.Windows.Forms.Label labelStoreCategory;
        private System.Windows.Forms.DateTimePicker dateTimeReserveStart;
        private System.Windows.Forms.Label labelReserveDate;
        private System.Windows.Forms.GroupBox groupOrderQuery;
        private System.Windows.Forms.DataGridView dataGridOrderList;
        private System.Windows.Forms.ComboBox comboStoreList;
        private System.Windows.Forms.Label labelStoreList;
    }
}