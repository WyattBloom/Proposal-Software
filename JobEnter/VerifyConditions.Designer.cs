namespace JobEnter
{
    partial class VerifyConditions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbox1
            // 
            this.lbox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox1.FormattingEnabled = true;
            this.lbox1.ItemHeight = 20;
            this.lbox1.Location = new System.Drawing.Point(2, 31);
            this.lbox1.Margin = new System.Windows.Forms.Padding(2);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(826, 284);
            this.lbox1.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(4, 321);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPrice.Location = new System.Drawing.Point(71, 321);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(219, 26);
            this.boxPrice.TabIndex = 5;
            // 
            // VerifyConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lbox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerifyConditions";
            this.Size = new System.Drawing.Size(904, 403);
            this.Load += new System.EventHandler(this.VerifyConditions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox boxPrice;
    }
}
