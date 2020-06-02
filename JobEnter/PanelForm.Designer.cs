namespace JobEnter
{
    partial class PanelForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.selectServices1 = new JobEnter.SelectServices();
            this.verifyConditions1 = new JobEnter.VerifyConditions();
            this.clientInfo1 = new JobEnter.ClientInfo();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(228, 112);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Enter Client Info";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(0, 111);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(228, 112);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Select Services";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 633);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 112);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter Pricing";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectServices1
            // 
            this.selectServices1.Location = new System.Drawing.Point(238, 12);
            this.selectServices1.Name = "selectServices1";
            this.selectServices1.Size = new System.Drawing.Size(1030, 569);
            this.selectServices1.TabIndex = 25;
            this.selectServices1.Visible = false;
            // 
            // verifyConditions1
            // 
            this.verifyConditions1.Location = new System.Drawing.Point(238, 12);
            this.verifyConditions1.Name = "verifyConditions1";
            this.verifyConditions1.Size = new System.Drawing.Size(807, 392);
            this.verifyConditions1.TabIndex = 24;
            this.verifyConditions1.Visible = false;
            // 
            // clientInfo1
            // 
            this.clientInfo1.Location = new System.Drawing.Point(236, 12);
            this.clientInfo1.Name = "clientInfo1";
            this.clientInfo1.Size = new System.Drawing.Size(741, 569);
            this.clientInfo1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 635);
            this.Controls.Add(this.clientInfo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectServices1);
            this.Controls.Add(this.verifyConditions1);
            this.Name = "PanelForm";
            this.Text = "Job Proposal Software";
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel1;
        private ClientInfo clientInfo1;
        private System.Windows.Forms.Button button1;
        private VerifyConditions verifyConditions1;
        private SelectServices newHomeServices1;
        private SelectServices selectServices1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}