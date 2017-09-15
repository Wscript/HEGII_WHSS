using System;
using System.Windows.Forms;

namespace HEGII_WHSS
{
    partial class formWarehouseMgt
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
            this.groupWarehouseQuery = new System.Windows.Forms.GroupBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.checkIsAvailable = new System.Windows.Forms.CheckBox();
            this.textWarehouseCode = new System.Windows.Forms.TextBox();
            this.labelWarehouseCode = new System.Windows.Forms.Label();
            this.textWarehouseName = new System.Windows.Forms.TextBox();
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.dataGridWerahouse = new System.Windows.Forms.DataGridView();
            this.buttonWarehouseAdd = new System.Windows.Forms.Button();
            this.buttonChangeSave = new System.Windows.Forms.Button();
            this.groupWarehouseQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWerahouse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupWarehouseQuery
            // 
            this.groupWarehouseQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupWarehouseQuery.Controls.Add(this.buttonQuery);
            this.groupWarehouseQuery.Controls.Add(this.checkIsAvailable);
            this.groupWarehouseQuery.Controls.Add(this.textWarehouseCode);
            this.groupWarehouseQuery.Controls.Add(this.labelWarehouseCode);
            this.groupWarehouseQuery.Controls.Add(this.textWarehouseName);
            this.groupWarehouseQuery.Controls.Add(this.labelWarehouseName);
            this.groupWarehouseQuery.Location = new System.Drawing.Point(14, 14);
            this.groupWarehouseQuery.Margin = new System.Windows.Forms.Padding(5);
            this.groupWarehouseQuery.Name = "groupWarehouseQuery";
            this.groupWarehouseQuery.Padding = new System.Windows.Forms.Padding(5);
            this.groupWarehouseQuery.Size = new System.Drawing.Size(765, 131);
            this.groupWarehouseQuery.TabIndex = 0;
            this.groupWarehouseQuery.TabStop = false;
            this.groupWarehouseQuery.Text = "仓库查询";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuery.Location = new System.Drawing.Point(594, 75);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(93, 35);
            this.buttonQuery.TabIndex = 16;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // checkIsAvailable
            // 
            this.checkIsAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsAvailable.AutoSize = true;
            this.checkIsAvailable.Location = new System.Drawing.Point(82, 81);
            this.checkIsAvailable.Name = "checkIsAvailable";
            this.checkIsAvailable.Size = new System.Drawing.Size(141, 25);
            this.checkIsAvailable.TabIndex = 4;
            this.checkIsAvailable.Text = "包含已禁用仓库";
            this.checkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // textWarehouseCode
            // 
            this.textWarehouseCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textWarehouseCode.Location = new System.Drawing.Point(476, 33);
            this.textWarehouseCode.Name = "textWarehouseCode";
            this.textWarehouseCode.Size = new System.Drawing.Size(211, 29);
            this.textWarehouseCode.TabIndex = 3;
            // 
            // labelWarehouseCode
            // 
            this.labelWarehouseCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouseCode.AutoSize = true;
            this.labelWarehouseCode.Location = new System.Drawing.Point(396, 36);
            this.labelWarehouseCode.Name = "labelWarehouseCode";
            this.labelWarehouseCode.Size = new System.Drawing.Size(74, 21);
            this.labelWarehouseCode.TabIndex = 2;
            this.labelWarehouseCode.Text = "仓库代码";
            // 
            // textWarehouseName
            // 
            this.textWarehouseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textWarehouseName.Location = new System.Drawing.Point(158, 33);
            this.textWarehouseName.Name = "textWarehouseName";
            this.textWarehouseName.Size = new System.Drawing.Size(211, 29);
            this.textWarehouseName.TabIndex = 1;
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.Location = new System.Drawing.Point(78, 36);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(74, 21);
            this.labelWarehouseName.TabIndex = 0;
            this.labelWarehouseName.Text = "仓库名称";
            // 
            // dataGridWerahouse
            // 
            this.dataGridWerahouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridWerahouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWerahouse.Location = new System.Drawing.Point(14, 210);
            this.dataGridWerahouse.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridWerahouse.Name = "dataGridWerahouse";
            this.dataGridWerahouse.RowTemplate.Height = 23;
            this.dataGridWerahouse.Size = new System.Drawing.Size(765, 277);
            this.dataGridWerahouse.TabIndex = 1;
            // 
            // buttonWarehouseAdd
            // 
            this.buttonWarehouseAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonWarehouseAdd.Location = new System.Drawing.Point(222, 160);
            this.buttonWarehouseAdd.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonWarehouseAdd.Name = "buttonWarehouseAdd";
            this.buttonWarehouseAdd.Size = new System.Drawing.Size(93, 35);
            this.buttonWarehouseAdd.TabIndex = 15;
            this.buttonWarehouseAdd.Text = "新增仓库";
            this.buttonWarehouseAdd.UseVisualStyleBackColor = true;
            this.buttonWarehouseAdd.Click += new System.EventHandler(this.buttonWarehouseAdd_Click);
            // 
            // buttonChangeSave
            // 
            this.buttonChangeSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChangeSave.Location = new System.Drawing.Point(478, 160);
            this.buttonChangeSave.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.buttonChangeSave.Name = "buttonChangeSave";
            this.buttonChangeSave.Size = new System.Drawing.Size(93, 35);
            this.buttonChangeSave.TabIndex = 16;
            this.buttonChangeSave.Text = "保存修改";
            this.buttonChangeSave.UseVisualStyleBackColor = true;
            // 
            // formWarehouseMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 501);
            this.Controls.Add(this.buttonChangeSave);
            this.Controls.Add(this.dataGridWerahouse);
            this.Controls.Add(this.buttonWarehouseAdd);
            this.Controls.Add(this.groupWarehouseQuery);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formWarehouseMgt";
            this.Text = "仓库管理";
            this.Load += new System.EventHandler(this.formWarehouseMgt_Load);
            this.DoubleClick += new System.EventHandler(this.formWerahouseMgt_DoubleClick);
            this.groupWarehouseQuery.ResumeLayout(false);
            this.groupWarehouseQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWerahouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupWarehouseQuery;
        private System.Windows.Forms.CheckBox checkIsAvailable;
        private System.Windows.Forms.TextBox textWarehouseCode;
        private System.Windows.Forms.Label labelWarehouseCode;
        private System.Windows.Forms.TextBox textWarehouseName;
        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.DataGridView dataGridWerahouse;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonWarehouseAdd;
        private Button buttonChangeSave;
    }
}