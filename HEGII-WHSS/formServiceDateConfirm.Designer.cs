namespace HEGII_WHSS
{
    partial class formServiceDateConfirm
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
            this.groupConfirmInformation = new System.Windows.Forms.GroupBox();
            this.dataGridWaitingConfirmOrder = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelWaitingConfirmOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWaitingConfirmOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConfirmInformation
            // 
            this.groupConfirmInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConfirmInformation.Location = new System.Drawing.Point(599, 12);
            this.groupConfirmInformation.Name = "groupConfirmInformation";
            this.groupConfirmInformation.Size = new System.Drawing.Size(346, 504);
            this.groupConfirmInformation.TabIndex = 1;
            this.groupConfirmInformation.TabStop = false;
            // 
            // dataGridWaitingConfirmOrder
            // 
            this.dataGridWaitingConfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridWaitingConfirmOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWaitingConfirmOrder.Location = new System.Drawing.Point(12, 33);
            this.dataGridWaitingConfirmOrder.Name = "dataGridWaitingConfirmOrder";
            this.dataGridWaitingConfirmOrder.RowTemplate.Height = 23;
            this.dataGridWaitingConfirmOrder.Size = new System.Drawing.Size(581, 483);
            this.dataGridWaitingConfirmOrder.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 522);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(933, 229);
            this.dataGridView2.TabIndex = 3;
            // 
            // labelWaitingConfirmOrder
            // 
            this.labelWaitingConfirmOrder.AutoSize = true;
            this.labelWaitingConfirmOrder.Location = new System.Drawing.Point(12, 9);
            this.labelWaitingConfirmOrder.Name = "labelWaitingConfirmOrder";
            this.labelWaitingConfirmOrder.Size = new System.Drawing.Size(106, 21);
            this.labelWaitingConfirmOrder.TabIndex = 4;
            this.labelWaitingConfirmOrder.Text = "待确认服务单";
            // 
            // formServiceDateConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 763);
            this.Controls.Add(this.labelWaitingConfirmOrder);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridWaitingConfirmOrder);
            this.Controls.Add(this.groupConfirmInformation);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formServiceDateConfirm";
            this.Text = "服务日期确认";
            this.Load += new System.EventHandler(this.formServiceDateConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWaitingConfirmOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConfirmInformation;
        private System.Windows.Forms.DataGridView dataGridWaitingConfirmOrder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelWaitingConfirmOrder;
    }
}