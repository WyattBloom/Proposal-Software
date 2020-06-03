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
            this.verifyConditions1 = new JobEnter.VerifyConditions();
            this.clientInfo1 = new JobEnter.ClientInfo();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
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
            this.btnClientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientInfo.Name = "btnClientInfo";
            this.btnClientInfo.Size = new System.Drawing.Size(173, 102);
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
            this.btnSelectServices.Location = new System.Drawing.Point(0, 100);
            this.btnSelectServices.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectServices.Name = "btnSelectServices";
            this.btnSelectServices.Size = new System.Drawing.Size(173, 102);
            this.btnSelectServices.TabIndex = 2;
            this.btnSelectServices.Text = "Select Services";
            this.btnSelectServices.UseVisualStyleBackColor = false;
            this.btnSelectServices.Click += new System.EventHandler(this.btnSelectServices_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnPricingPage);
            this.panel1.Controls.Add(this.btnSelectServices);
            this.panel1.Controls.Add(this.btnClientInfo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 525);
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
            this.btnPricingPage.Location = new System.Drawing.Point(0, 196);
            this.btnPricingPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPricingPage.Name = "btnPricingPage";
            this.btnPricingPage.Size = new System.Drawing.Size(173, 102);
            this.btnPricingPage.TabIndex = 3;
            this.btnPricingPage.Text = "Enter Pricing";
            this.btnPricingPage.UseVisualStyleBackColor = false;
            this.btnPricingPage.Click += new System.EventHandler(this.btnPricingPage_Click);
            // 
            // verifyConditions1
            // 
            this.verifyConditions1.Location = new System.Drawing.Point(178, 10);
            this.verifyConditions1.Margin = new System.Windows.Forms.Padding(2);
            this.verifyConditions1.Name = "verifyConditions1";
            this.verifyConditions1.Size = new System.Drawing.Size(605, 318);
            this.verifyConditions1.TabIndex = 24;
            this.verifyConditions1.Visible = false;
            this.verifyConditions1.Load += new System.EventHandler(this.verifyConditions1_Load);
            // 
            // clientInfo1
            // 
            this.clientInfo1.Address = "";
            this.clientInfo1.City = "";
            this.clientInfo1.Email = "";
            this.clientInfo1.Location = new System.Drawing.Point(177, 10);
            this.clientInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.clientInfo1.Name = "clientInfo1";
            this.clientInfo1.Number = null;
            this.clientInfo1.Size = new System.Drawing.Size(556, 464);
            this.clientInfo1.State = "";
            this.clientInfo1.TabIndex = 3;
            this.clientInfo1.Zip = "";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(298, 479);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(160, 38);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(464, 479);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(160, 38);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 525);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clientInfo1);
            this.Controls.Add(this.verifyConditions1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private SelectServices newHomeServices1;
        private SelectServices selectServices1;
        private SelectServices selectServices2;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}