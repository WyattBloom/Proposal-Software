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
            this.boxStakePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbox1
            // 
            this.lbox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox1.FormattingEnabled = true;
            this.lbox1.ItemHeight = 25;
            this.lbox1.Location = new System.Drawing.Point(3, 38);
            this.lbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(1100, 329);
            this.lbox1.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(3, 480);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(136, 29);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Total Price:";
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPrice.Location = new System.Drawing.Point(196, 480);
            this.boxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(363, 30);
            this.boxPrice.TabIndex = 2;
            // 
            // boxStakePrice
            // 
            this.boxStakePrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStakePrice.Location = new System.Drawing.Point(196, 439);
            this.boxStakePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxStakePrice.Name = "boxStakePrice";
            this.boxStakePrice.Size = new System.Drawing.Size(363, 30);
            this.boxStakePrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stake Price:";
            // 
            // boxDays
            // 
            this.boxDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDays.Location = new System.Drawing.Point(196, 400);
            this.boxDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxDays.Name = "boxDays";
            this.boxDays.Size = new System.Drawing.Size(363, 30);
            this.boxDays.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Days Estimate:";
            // 
            // VerifyConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxStakePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lbox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VerifyConditions";
            this.Size = new System.Drawing.Size(1205, 544);
            this.Load += new System.EventHandler(this.VerifyConditions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.TextBox boxStakePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxDays;
        private System.Windows.Forms.Label label2;
    }
}
