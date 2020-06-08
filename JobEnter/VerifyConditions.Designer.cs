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
            this.SuspendLayout();
            // 
            // lbox1
            // 
            this.lbox1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox1.FormattingEnabled = true;
            this.lbox1.ItemHeight = 25;
            this.lbox1.Location = new System.Drawing.Point(3, 2);
            this.lbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(927, 254);
            this.lbox1.TabIndex = 3;
            // 
            // VerifyConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VerifyConditions";
            this.Size = new System.Drawing.Size(1205, 496);
            this.Load += new System.EventHandler(this.VerifyConditions_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbox1;
    }
}
