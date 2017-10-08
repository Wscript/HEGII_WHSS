namespace HEGII_WHSS
{
    partial class formOrderInput
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
            this.groupDateInfo = new System.Windows.Forms.GroupBox();
            this.checkReserveHold = new System.Windows.Forms.CheckBox();
            this.dateTimeReserveDate = new System.Windows.Forms.DateTimePicker();
            this.labelReserveDate = new System.Windows.Forms.Label();
            this.dateTimeFilingDate = new System.Windows.Forms.DateTimePicker();
            this.labelFilingDate = new System.Windows.Forms.Label();
            this.groupStoreInfo = new System.Windows.Forms.GroupBox();
            this.comboSalesStoreCategory = new System.Windows.Forms.ComboBox();
            this.labelSalesStoreCategory = new System.Windows.Forms.Label();
            this.comboSalesStoreList = new System.Windows.Forms.ComboBox();
            this.labelSalesStoreList = new System.Windows.Forms.Label();
            this.groupCustInfo = new System.Windows.Forms.GroupBox();
            this.comboServiceLocation = new System.Windows.Forms.ComboBox();
            this.labelServiceLocation = new System.Windows.Forms.Label();
            this.comboServiceArea = new System.Windows.Forms.ComboBox();
            this.labelServiceArea = new System.Windows.Forms.Label();
            this.textCustPhone = new System.Windows.Forms.TextBox();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.textCustAddress = new System.Windows.Forms.TextBox();
            this.labelCustAddress = new System.Windows.Forms.Label();
            this.textCustName = new System.Windows.Forms.TextBox();
            this.labelCustName = new System.Windows.Forms.Label();
            this.groupOtherInfo = new System.Windows.Forms.GroupBox();
            this.checkIsTemporary = new System.Windows.Forms.CheckBox();
            this.comboApplyWayList = new System.Windows.Forms.ComboBox();
            this.labelApplyWayList = new System.Windows.Forms.Label();
            this.comboOrderTypeList = new System.Windows.Forms.ComboBox();
            this.labelOrderTypeList = new System.Windows.Forms.Label();
            this.textOperatorMemo = new System.Windows.Forms.TextBox();
            this.labelOperatorMemo = new System.Windows.Forms.Label();
            this.textPNAndQTY = new System.Windows.Forms.TextBox();
            this.labelPNAndQTY = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupDateInfo.SuspendLayout();
            this.groupStoreInfo.SuspendLayout();
            this.groupCustInfo.SuspendLayout();
            this.groupOtherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDateInfo
            // 
            this.groupDateInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupDateInfo.Controls.Add(this.checkReserveHold);
            this.groupDateInfo.Controls.Add(this.dateTimeReserveDate);
            this.groupDateInfo.Controls.Add(this.labelReserveDate);
            this.groupDateInfo.Controls.Add(this.dateTimeFilingDate);
            this.groupDateInfo.Controls.Add(this.labelFilingDate);
            this.groupDateInfo.Location = new System.Drawing.Point(20, 21);
            this.groupDateInfo.Margin = new System.Windows.Forms.Padding(5);
            this.groupDateInfo.Name = "groupDateInfo";
            this.groupDateInfo.Padding = new System.Windows.Forms.Padding(5);
            this.groupDateInfo.Size = new System.Drawing.Size(862, 75);
            this.groupDateInfo.TabIndex = 0;
            this.groupDateInfo.TabStop = false;
            this.groupDateInfo.Text = "时间信息";
            // 
            // checkReserveHold
            // 
            this.checkReserveHold.AutoSize = true;
            this.checkReserveHold.Location = new System.Drawing.Point(731, 31);
            this.checkReserveHold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkReserveHold.Name = "checkReserveHold";
            this.checkReserveHold.Size = new System.Drawing.Size(125, 25);
            this.checkReserveHold.TabIndex = 35;
            this.checkReserveHold.Text = "预约时间待定";
            this.checkReserveHold.UseVisualStyleBackColor = true;
            // 
            // dateTimeReserveDate
            // 
            this.dateTimeReserveDate.Location = new System.Drawing.Point(454, 29);
            this.dateTimeReserveDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimeReserveDate.Name = "dateTimeReserveDate";
            this.dateTimeReserveDate.Size = new System.Drawing.Size(249, 29);
            this.dateTimeReserveDate.TabIndex = 34;
            // 
            // labelReserveDate
            // 
            this.labelReserveDate.AutoSize = true;
            this.labelReserveDate.Location = new System.Drawing.Point(370, 33);
            this.labelReserveDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelReserveDate.Name = "labelReserveDate";
            this.labelReserveDate.Size = new System.Drawing.Size(74, 21);
            this.labelReserveDate.TabIndex = 33;
            this.labelReserveDate.Text = "预约日期";
            // 
            // dateTimeFilingDate
            // 
            this.dateTimeFilingDate.Location = new System.Drawing.Point(92, 29);
            this.dateTimeFilingDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimeFilingDate.Name = "dateTimeFilingDate";
            this.dateTimeFilingDate.Size = new System.Drawing.Size(249, 29);
            this.dateTimeFilingDate.TabIndex = 32;
            // 
            // labelFilingDate
            // 
            this.labelFilingDate.AutoSize = true;
            this.labelFilingDate.ForeColor = System.Drawing.Color.Red;
            this.labelFilingDate.Location = new System.Drawing.Point(8, 33);
            this.labelFilingDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFilingDate.Name = "labelFilingDate";
            this.labelFilingDate.Size = new System.Drawing.Size(74, 21);
            this.labelFilingDate.TabIndex = 31;
            this.labelFilingDate.Text = "申报日期";
            // 
            // groupStoreInfo
            // 
            this.groupStoreInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupStoreInfo.Controls.Add(this.comboSalesStoreCategory);
            this.groupStoreInfo.Controls.Add(this.labelSalesStoreCategory);
            this.groupStoreInfo.Controls.Add(this.comboSalesStoreList);
            this.groupStoreInfo.Controls.Add(this.labelSalesStoreList);
            this.groupStoreInfo.Location = new System.Drawing.Point(20, 104);
            this.groupStoreInfo.Name = "groupStoreInfo";
            this.groupStoreInfo.Size = new System.Drawing.Size(862, 75);
            this.groupStoreInfo.TabIndex = 1;
            this.groupStoreInfo.TabStop = false;
            this.groupStoreInfo.Text = "门店信息";
            // 
            // comboSalesStoreCategory
            // 
            this.comboSalesStoreCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSalesStoreCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSalesStoreCategory.FormattingEnabled = true;
            this.comboSalesStoreCategory.Location = new System.Drawing.Point(92, 27);
            this.comboSalesStoreCategory.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboSalesStoreCategory.Name = "comboSalesStoreCategory";
            this.comboSalesStoreCategory.Size = new System.Drawing.Size(249, 29);
            this.comboSalesStoreCategory.TabIndex = 20;
            this.comboSalesStoreCategory.SelectedIndexChanged += new System.EventHandler(this.comboSalesStoreType_SelectedIndexChanged);
            // 
            // labelSalesStoreCategory
            // 
            this.labelSalesStoreCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSalesStoreCategory.AutoSize = true;
            this.labelSalesStoreCategory.Location = new System.Drawing.Point(8, 31);
            this.labelSalesStoreCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSalesStoreCategory.Name = "labelSalesStoreCategory";
            this.labelSalesStoreCategory.Size = new System.Drawing.Size(74, 21);
            this.labelSalesStoreCategory.TabIndex = 19;
            this.labelSalesStoreCategory.Text = "门店类型";
            // 
            // comboSalesStoreList
            // 
            this.comboSalesStoreList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSalesStoreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSalesStoreList.FormattingEnabled = true;
            this.comboSalesStoreList.Location = new System.Drawing.Point(454, 27);
            this.comboSalesStoreList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboSalesStoreList.Name = "comboSalesStoreList";
            this.comboSalesStoreList.Size = new System.Drawing.Size(249, 29);
            this.comboSalesStoreList.TabIndex = 18;
            // 
            // labelSalesStoreList
            // 
            this.labelSalesStoreList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSalesStoreList.AutoSize = true;
            this.labelSalesStoreList.Location = new System.Drawing.Point(370, 31);
            this.labelSalesStoreList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSalesStoreList.Name = "labelSalesStoreList";
            this.labelSalesStoreList.Size = new System.Drawing.Size(74, 21);
            this.labelSalesStoreList.TabIndex = 17;
            this.labelSalesStoreList.Text = "销售店面";
            // 
            // groupCustInfo
            // 
            this.groupCustInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupCustInfo.Controls.Add(this.comboServiceLocation);
            this.groupCustInfo.Controls.Add(this.labelServiceLocation);
            this.groupCustInfo.Controls.Add(this.comboServiceArea);
            this.groupCustInfo.Controls.Add(this.labelServiceArea);
            this.groupCustInfo.Controls.Add(this.textCustPhone);
            this.groupCustInfo.Controls.Add(this.labelCustPhone);
            this.groupCustInfo.Controls.Add(this.textCustAddress);
            this.groupCustInfo.Controls.Add(this.labelCustAddress);
            this.groupCustInfo.Controls.Add(this.textCustName);
            this.groupCustInfo.Controls.Add(this.labelCustName);
            this.groupCustInfo.Location = new System.Drawing.Point(20, 185);
            this.groupCustInfo.Name = "groupCustInfo";
            this.groupCustInfo.Size = new System.Drawing.Size(862, 158);
            this.groupCustInfo.TabIndex = 2;
            this.groupCustInfo.TabStop = false;
            this.groupCustInfo.Text = "客户信息";
            // 
            // comboServiceLocation
            // 
            this.comboServiceLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboServiceLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServiceLocation.FormattingEnabled = true;
            this.comboServiceLocation.Location = new System.Drawing.Point(92, 109);
            this.comboServiceLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboServiceLocation.Name = "comboServiceLocation";
            this.comboServiceLocation.Size = new System.Drawing.Size(249, 29);
            this.comboServiceLocation.TabIndex = 36;
            this.comboServiceLocation.SelectedIndexChanged += new System.EventHandler(this.comboServiceLocation_SelectedIndexChanged);
            // 
            // labelServiceLocation
            // 
            this.labelServiceLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelServiceLocation.AutoSize = true;
            this.labelServiceLocation.ForeColor = System.Drawing.Color.Red;
            this.labelServiceLocation.Location = new System.Drawing.Point(8, 113);
            this.labelServiceLocation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelServiceLocation.Name = "labelServiceLocation";
            this.labelServiceLocation.Size = new System.Drawing.Size(58, 21);
            this.labelServiceLocation.TabIndex = 35;
            this.labelServiceLocation.Text = "大范围";
            // 
            // comboServiceArea
            // 
            this.comboServiceArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboServiceArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServiceArea.FormattingEnabled = true;
            this.comboServiceArea.Location = new System.Drawing.Point(454, 108);
            this.comboServiceArea.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboServiceArea.Name = "comboServiceArea";
            this.comboServiceArea.Size = new System.Drawing.Size(249, 29);
            this.comboServiceArea.TabIndex = 34;
            // 
            // labelServiceArea
            // 
            this.labelServiceArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelServiceArea.AutoSize = true;
            this.labelServiceArea.ForeColor = System.Drawing.Color.Red;
            this.labelServiceArea.Location = new System.Drawing.Point(370, 112);
            this.labelServiceArea.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelServiceArea.Name = "labelServiceArea";
            this.labelServiceArea.Size = new System.Drawing.Size(74, 21);
            this.labelServiceArea.TabIndex = 33;
            this.labelServiceArea.Text = "服务区域";
            // 
            // textCustPhone
            // 
            this.textCustPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCustPhone.Location = new System.Drawing.Point(454, 24);
            this.textCustPhone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textCustPhone.Name = "textCustPhone";
            this.textCustPhone.Size = new System.Drawing.Size(400, 29);
            this.textCustPhone.TabIndex = 32;
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.ForeColor = System.Drawing.Color.Red;
            this.labelCustPhone.Location = new System.Drawing.Point(370, 28);
            this.labelCustPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(74, 21);
            this.labelCustPhone.TabIndex = 31;
            this.labelCustPhone.Text = "客户电话";
            // 
            // textCustAddress
            // 
            this.textCustAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCustAddress.Location = new System.Drawing.Point(92, 67);
            this.textCustAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textCustAddress.Name = "textCustAddress";
            this.textCustAddress.Size = new System.Drawing.Size(762, 29);
            this.textCustAddress.TabIndex = 30;
            // 
            // labelCustAddress
            // 
            this.labelCustAddress.AutoSize = true;
            this.labelCustAddress.ForeColor = System.Drawing.Color.Red;
            this.labelCustAddress.Location = new System.Drawing.Point(8, 71);
            this.labelCustAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCustAddress.Name = "labelCustAddress";
            this.labelCustAddress.Size = new System.Drawing.Size(74, 21);
            this.labelCustAddress.TabIndex = 29;
            this.labelCustAddress.Text = "客户地址";
            // 
            // textCustName
            // 
            this.textCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCustName.Location = new System.Drawing.Point(92, 24);
            this.textCustName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textCustName.Name = "textCustName";
            this.textCustName.Size = new System.Drawing.Size(249, 29);
            this.textCustName.TabIndex = 28;
            // 
            // labelCustName
            // 
            this.labelCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustName.AutoSize = true;
            this.labelCustName.Location = new System.Drawing.Point(8, 28);
            this.labelCustName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(74, 21);
            this.labelCustName.TabIndex = 27;
            this.labelCustName.Text = "客户姓名";
            // 
            // groupOtherInfo
            // 
            this.groupOtherInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupOtherInfo.Controls.Add(this.checkIsTemporary);
            this.groupOtherInfo.Controls.Add(this.comboApplyWayList);
            this.groupOtherInfo.Controls.Add(this.labelApplyWayList);
            this.groupOtherInfo.Controls.Add(this.comboOrderTypeList);
            this.groupOtherInfo.Controls.Add(this.labelOrderTypeList);
            this.groupOtherInfo.Location = new System.Drawing.Point(20, 349);
            this.groupOtherInfo.Name = "groupOtherInfo";
            this.groupOtherInfo.Size = new System.Drawing.Size(862, 75);
            this.groupOtherInfo.TabIndex = 3;
            this.groupOtherInfo.TabStop = false;
            this.groupOtherInfo.Text = "其他信息";
            // 
            // checkIsTemporary
            // 
            this.checkIsTemporary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsTemporary.AutoSize = true;
            this.checkIsTemporary.Location = new System.Drawing.Point(731, 26);
            this.checkIsTemporary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkIsTemporary.Name = "checkIsTemporary";
            this.checkIsTemporary.Size = new System.Drawing.Size(93, 25);
            this.checkIsTemporary.TabIndex = 36;
            this.checkIsTemporary.Text = "临时加单";
            this.checkIsTemporary.UseVisualStyleBackColor = true;
            // 
            // comboApplyWayList
            // 
            this.comboApplyWayList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboApplyWayList.BackColor = System.Drawing.SystemColors.Window;
            this.comboApplyWayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboApplyWayList.FormattingEnabled = true;
            this.comboApplyWayList.Location = new System.Drawing.Point(454, 24);
            this.comboApplyWayList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboApplyWayList.Name = "comboApplyWayList";
            this.comboApplyWayList.Size = new System.Drawing.Size(249, 29);
            this.comboApplyWayList.TabIndex = 33;
            // 
            // labelApplyWayList
            // 
            this.labelApplyWayList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelApplyWayList.AutoSize = true;
            this.labelApplyWayList.ForeColor = System.Drawing.Color.Red;
            this.labelApplyWayList.Location = new System.Drawing.Point(370, 27);
            this.labelApplyWayList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelApplyWayList.Name = "labelApplyWayList";
            this.labelApplyWayList.Size = new System.Drawing.Size(74, 21);
            this.labelApplyWayList.TabIndex = 32;
            this.labelApplyWayList.Text = "报单途径";
            // 
            // comboOrderTypeList
            // 
            this.comboOrderTypeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboOrderTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderTypeList.FormattingEnabled = true;
            this.comboOrderTypeList.Location = new System.Drawing.Point(92, 24);
            this.comboOrderTypeList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboOrderTypeList.Name = "comboOrderTypeList";
            this.comboOrderTypeList.Size = new System.Drawing.Size(249, 29);
            this.comboOrderTypeList.TabIndex = 31;
            // 
            // labelOrderTypeList
            // 
            this.labelOrderTypeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOrderTypeList.AutoSize = true;
            this.labelOrderTypeList.ForeColor = System.Drawing.Color.Red;
            this.labelOrderTypeList.Location = new System.Drawing.Point(8, 27);
            this.labelOrderTypeList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOrderTypeList.Name = "labelOrderTypeList";
            this.labelOrderTypeList.Size = new System.Drawing.Size(74, 21);
            this.labelOrderTypeList.TabIndex = 30;
            this.labelOrderTypeList.Text = "服务类型";
            // 
            // textOperatorMemo
            // 
            this.textOperatorMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textOperatorMemo.Location = new System.Drawing.Point(474, 463);
            this.textOperatorMemo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textOperatorMemo.Multiline = true;
            this.textOperatorMemo.Name = "textOperatorMemo";
            this.textOperatorMemo.Size = new System.Drawing.Size(402, 123);
            this.textOperatorMemo.TabIndex = 26;
            // 
            // labelOperatorMemo
            // 
            this.labelOperatorMemo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOperatorMemo.AutoSize = true;
            this.labelOperatorMemo.Location = new System.Drawing.Point(470, 437);
            this.labelOperatorMemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperatorMemo.Name = "labelOperatorMemo";
            this.labelOperatorMemo.Size = new System.Drawing.Size(74, 21);
            this.labelOperatorMemo.TabIndex = 25;
            this.labelOperatorMemo.Text = "客服备注";
            // 
            // textPNAndQTY
            // 
            this.textPNAndQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textPNAndQTY.Location = new System.Drawing.Point(32, 463);
            this.textPNAndQTY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPNAndQTY.Multiline = true;
            this.textPNAndQTY.Name = "textPNAndQTY";
            this.textPNAndQTY.Size = new System.Drawing.Size(402, 123);
            this.textPNAndQTY.TabIndex = 24;
            // 
            // labelPNAndQTY
            // 
            this.labelPNAndQTY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPNAndQTY.AutoSize = true;
            this.labelPNAndQTY.ForeColor = System.Drawing.Color.Red;
            this.labelPNAndQTY.Location = new System.Drawing.Point(28, 437);
            this.labelPNAndQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPNAndQTY.Name = "labelPNAndQTY";
            this.labelPNAndQTY.Size = new System.Drawing.Size(145, 21);
            this.labelPNAndQTY.TabIndex = 23;
            this.labelPNAndQTY.Text = "型号数量/门店备注";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSubmit.Location = new System.Drawing.Point(751, 601);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(93, 35);
            this.buttonSubmit.TabIndex = 29;
            this.buttonSubmit.Text = "提交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // formOrderInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 654);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textOperatorMemo);
            this.Controls.Add(this.labelOperatorMemo);
            this.Controls.Add(this.textPNAndQTY);
            this.Controls.Add(this.labelPNAndQTY);
            this.Controls.Add(this.groupOtherInfo);
            this.Controls.Add(this.groupCustInfo);
            this.Controls.Add(this.groupStoreInfo);
            this.Controls.Add(this.groupDateInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formOrderInput";
            this.Text = "服务单录入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formOrderInput_FormClosing);
            this.Load += new System.EventHandler(this.formOrderInput_Load);
            this.groupDateInfo.ResumeLayout(false);
            this.groupDateInfo.PerformLayout();
            this.groupStoreInfo.ResumeLayout(false);
            this.groupStoreInfo.PerformLayout();
            this.groupCustInfo.ResumeLayout(false);
            this.groupCustInfo.PerformLayout();
            this.groupOtherInfo.ResumeLayout(false);
            this.groupOtherInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDateInfo;
        private System.Windows.Forms.CheckBox checkReserveHold;
        private System.Windows.Forms.DateTimePicker dateTimeReserveDate;
        private System.Windows.Forms.Label labelReserveDate;
        private System.Windows.Forms.DateTimePicker dateTimeFilingDate;
        private System.Windows.Forms.Label labelFilingDate;
        private System.Windows.Forms.GroupBox groupStoreInfo;
        private System.Windows.Forms.ComboBox comboSalesStoreList;
        private System.Windows.Forms.Label labelSalesStoreList;
        private System.Windows.Forms.GroupBox groupCustInfo;
        private System.Windows.Forms.ComboBox comboServiceArea;
        private System.Windows.Forms.Label labelServiceArea;
        private System.Windows.Forms.TextBox textCustPhone;
        private System.Windows.Forms.Label labelCustPhone;
        private System.Windows.Forms.TextBox textCustAddress;
        private System.Windows.Forms.Label labelCustAddress;
        private System.Windows.Forms.TextBox textCustName;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.GroupBox groupOtherInfo;
        private System.Windows.Forms.ComboBox comboApplyWayList;
        private System.Windows.Forms.Label labelApplyWayList;
        private System.Windows.Forms.ComboBox comboOrderTypeList;
        private System.Windows.Forms.Label labelOrderTypeList;
        private System.Windows.Forms.CheckBox checkIsTemporary;
        private System.Windows.Forms.TextBox textOperatorMemo;
        private System.Windows.Forms.Label labelOperatorMemo;
        private System.Windows.Forms.TextBox textPNAndQTY;
        private System.Windows.Forms.Label labelPNAndQTY;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboServiceLocation;
        private System.Windows.Forms.Label labelServiceLocation;
        private System.Windows.Forms.ComboBox comboSalesStoreCategory;
        private System.Windows.Forms.Label labelSalesStoreCategory;
    }
}