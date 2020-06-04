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
            this.btnClientInfo = new System.Windows.Forms.Button();
            this.btnSelectServices = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPricingPage = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.selectServices1 = new JobEnter.SelectServices();
            this.verifyConditions1 = new JobEnter.VerifyConditions();
            this.verifyPage = new JobEnter.VerifyConditions();
            this.clientInfo1 = new JobEnter.ClientInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientInfo
            // 
            this.btnClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClientInfo.FlatAppearance.BorderSize = 0;
            this.btnClientInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientInfo.Location = new System.Drawing.Point(0, 0);
            this.btnClientInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientInfo.Name = "btnClientInfo";
            this.btnClientInfo.Size = new System.Drawing.Size(231, 126);
            this.btnClientInfo.TabIndex = 1;
            this.btnClientInfo.Text = "Enter Client Info";
            this.btnClientInfo.UseVisualStyleBackColor = false;
            this.btnClientInfo.Click += new System.EventHandler(this.btnClientInfo_Click);
            // 
            // btnSelectServices
            // 
            this.btnSelectServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectServices.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSelectServices.FlatAppearance.BorderSize = 0;
            this.btnSelectServices.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectServices.Location = new System.Drawing.Point(0, 123);
            this.btnSelectServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectServices.Name = "btnSelectServices";
            this.btnSelectServices.Size = new System.Drawing.Size(231, 126);
            this.btnSelectServices.TabIndex = 2;
            this.btnSelectServices.Text = "Select Services";
            this.btnSelectServices.UseVisualStyleBackColor = false;
            this.btnSelectServices.Click += new System.EventHandler(this.btnSelectServices_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPricingPage);
            this.panel1.Controls.Add(this.btnSelectServices);
            this.panel1.Controls.Add(this.btnClientInfo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 646);
            this.panel1.TabIndex = 21;
            // 
            // btnPricingPage
            // 
            this.btnPricingPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPricingPage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPricingPage.FlatAppearance.BorderSize = 0;
            this.btnPricingPage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricingPage.Location = new System.Drawing.Point(0, 241);
            this.btnPricingPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPricingPage.Name = "btnPricingPage";
            this.btnPricingPage.Size = new System.Drawing.Size(231, 126);
            this.btnPricingPage.TabIndex = 3;
            this.btnPricingPage.Text = "Enter Pricing";
            this.btnPricingPage.UseVisualStyleBackColor = false;
            this.btnPricingPage.Click += new System.EventHandler(this.btnPricingPage_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(397, 590);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(213, 47);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(619, 590);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(213, 47);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // selectServices1
            // 
            this.selectServices1.Location = new System.Drawing.Point(237, 11);
            this.selectServices1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectServices1.Name = "selectServices1";
            this.selectServices1.Size = new System.Drawing.Size(968, 572);
            this.selectServices1.TabIndex = 29;
            this.selectServices1.Visible = false;
            // 
            // verifyConditions1
            // 
            this.verifyConditions1.Location = new System.Drawing.Point(237, 12);
            this.verifyConditions1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyConditions1.Name = "verifyConditions1";
            this.verifyConditions1.Size = new System.Drawing.Size(968, 391);
            this.verifyConditions1.TabIndex = 24;
            this.verifyConditions1.Visible = false;
            this.verifyConditions1.Load += new System.EventHandler(this.verifyConditions1_Load);
            // 
            // verifyPage
            // 
            this.verifyPage.Location = new System.Drawing.Point(238, 13);
            this.verifyPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyPage.Name = "verifyPage";
            this.verifyPage.Size = new System.Drawing.Size(807, 391);
            this.verifyPage.TabIndex = 28;
            this.verifyPage.Visible = false;
            this.verifyPage.Load += new System.EventHandler(this.verifyConditions2_Load);
            // 
            // clientInfo1
            // 
            this.clientInfo1.Address = "";
            this.clientInfo1.City = "";
            this.clientInfo1.Email = "";
            this.clientInfo1.Location = new System.Drawing.Point(236, 12);
            this.clientInfo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientInfo1.Name = "clientInfo1";
            this.clientInfo1.Number = null;
            this.clientInfo1.Size = new System.Drawing.Size(741, 571);
            this.clientInfo1.State = "";
            this.clientInfo1.TabIndex = 3;
            this.clientInfo1.Zip = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 646);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verifyConditions1);
            this.Controls.Add(this.verifyPage);
            this.Controls.Add(this.clientInfo1);
            this.Controls.Add(this.selectServices1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelForm";
            this.Text = "Job Proposal Software";
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClientInfo;
        private System.Windows.Forms.Button btnSelectServices;
        private System.Windows.Forms.Panel panel1;
        private ClientInfo clientInfo1;
        private System.Windows.Forms.Button btnPricingPage;
        private VerifyConditions verifyConditions1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private VerifyConditions verifyPage;
        private SelectServices selectServices1;
        private System.Windows.Forms.Button button1;
    }
}