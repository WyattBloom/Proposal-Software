namespace JobEnter
{
    partial class StakingPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxCorner = new System.Windows.Forms.TextBox();
            this.boxSTKPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which side/Corner?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staking Price:";
            // 
            // boxCorner
            // 
            this.boxCorner.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCorner.Location = new System.Drawing.Point(241, 22);
            this.boxCorner.Name = "boxCorner";
            this.boxCorner.Size = new System.Drawing.Size(381, 33);
            this.boxCorner.TabIndex = 2;
            // 
            // boxSTKPrice
            // 
            this.boxSTKPrice.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSTKPrice.Location = new System.Drawing.Point(241, 63);
            this.boxSTKPrice.Name = "boxSTKPrice";
            this.boxSTKPrice.Size = new System.Drawing.Size(381, 33);
            this.boxSTKPrice.TabIndex = 3;
            // 
            // StakingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxSTKPrice);
            this.Controls.Add(this.boxCorner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StakingPage";
            this.Size = new System.Drawing.Size(655, 180);
            this.Load += new System.EventHandler(this.StakingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxCorner;
        private System.Windows.Forms.TextBox boxSTKPrice;
    }
}
