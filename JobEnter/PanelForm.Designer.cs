﻿namespace JobEnter
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnJobType = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPricingPage = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smartsheetOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAccessTokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyPage = new JobEnter.VerifyConditions();
            this.jobType1 = new JobEnter.JobType();
            this.stakingPage1 = new JobEnter.StakingPage();
            this.selectServices1 = new JobEnter.SelectServices();
            this.clientInfo1 = new JobEnter.ClientInfo();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.btnSelectServices.Location = new System.Drawing.Point(0, 198);
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnJobType);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPricingPage);
            this.panel1.Controls.Add(this.btnSelectServices);
            this.panel1.Controls.Add(this.btnClientInfo);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 525);
            this.panel1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJobType
            // 
            this.btnJobType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJobType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnJobType.FlatAppearance.BorderSize = 0;
            this.btnJobType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobType.Location = new System.Drawing.Point(0, 99);
            this.btnJobType.Margin = new System.Windows.Forms.Padding(2);
            this.btnJobType.Name = "btnJobType";
            this.btnJobType.Size = new System.Drawing.Size(173, 102);
            this.btnJobType.TabIndex = 5;
            this.btnJobType.Text = "Select Job Type";
            this.btnJobType.UseVisualStyleBackColor = false;
            this.btnJobType.Click += new System.EventHandler(this.btnJobType_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPricingPage
            // 
            this.btnPricingPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPricingPage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPricingPage.FlatAppearance.BorderSize = 0;
            this.btnPricingPage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricingPage.Location = new System.Drawing.Point(0, 296);
            this.btnPricingPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPricingPage.Name = "btnPricingPage";
            this.btnPricingPage.Size = new System.Drawing.Size(173, 102);
            this.btnPricingPage.TabIndex = 3;
            this.btnPricingPage.Text = "Enter Pricing";
            this.btnPricingPage.UseVisualStyleBackColor = false;
            this.btnPricingPage.Click += new System.EventHandler(this.btnPricingPage_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(298, 506);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(160, 38);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(464, 506);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(160, 38);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smartsheetOptionsToolStripMenuItem,
            this.newJobEntryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smartsheetOptionsToolStripMenuItem
            // 
            this.smartsheetOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAccessTokeToolStripMenuItem});
            this.smartsheetOptionsToolStripMenuItem.Name = "smartsheetOptionsToolStripMenuItem";
            this.smartsheetOptionsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.smartsheetOptionsToolStripMenuItem.Text = "Smartsheet Options";
            // 
            // changeAccessTokeToolStripMenuItem
            // 
            this.changeAccessTokeToolStripMenuItem.Name = "changeAccessTokeToolStripMenuItem";
            this.changeAccessTokeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.changeAccessTokeToolStripMenuItem.Text = "Change Access Token";
            this.changeAccessTokeToolStripMenuItem.Click += new System.EventHandler(this.changeAccessTokeToolStripMenuItem_Click);
            // 
            // newJobEntryToolStripMenuItem
            // 
            this.newJobEntryToolStripMenuItem.Name = "newJobEntryToolStripMenuItem";
            this.newJobEntryToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.newJobEntryToolStripMenuItem.Text = "New job entry";
            this.newJobEntryToolStripMenuItem.Click += new System.EventHandler(this.newJobEntryToolStripMenuItem_Click);
            // 
            // verifyPage
            // 
            this.verifyPage.Location = new System.Drawing.Point(178, 27);
            this.verifyPage.Margin = new System.Windows.Forms.Padding(2);
            this.verifyPage.Name = "verifyPage";
            this.verifyPage.Size = new System.Drawing.Size(853, 467);
            this.verifyPage.TabIndex = 32;
            this.verifyPage.Visible = false;
            // 
            // jobType1
            // 
            this.jobType1.BackColor = System.Drawing.SystemColors.Control;
            this.jobType1.Location = new System.Drawing.Point(232, 59);
            this.jobType1.Margin = new System.Windows.Forms.Padding(2);
            this.jobType1.Name = "jobType1";
            this.jobType1.Size = new System.Drawing.Size(273, 245);
            this.jobType1.TabIndex = 30;
            this.jobType1.Visible = false;
            // 
            // stakingPage1
            // 
            this.stakingPage1.Corner = "";
            this.stakingPage1.Location = new System.Drawing.Point(211, 59);
            this.stakingPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stakingPage1.Name = "stakingPage1";
            this.stakingPage1.Size = new System.Drawing.Size(352, 146);
            this.stakingPage1.TabIndex = 33;
            this.stakingPage1.Visible = false;
            // 
            // selectServices1
            // 
            this.selectServices1.Location = new System.Drawing.Point(178, 27);
            this.selectServices1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectServices1.Name = "selectServices1";
            this.selectServices1.Size = new System.Drawing.Size(767, 445);
            this.selectServices1.TabIndex = 31;
            this.selectServices1.Visible = false;
            // 
            // clientInfo1
            // 
            this.clientInfo1.Address = "";
            this.clientInfo1.City = "";
            this.clientInfo1.Email = "";
            this.clientInfo1.Location = new System.Drawing.Point(178, 27);
            this.clientInfo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientInfo1.Name = "clientInfo1";
            this.clientInfo1.Number = "";
            this.clientInfo1.Size = new System.Drawing.Size(607, 474);
            this.clientInfo1.SpecialInstructions = "";
            this.clientInfo1.State = "";
            this.clientInfo1.TabIndex = 29;
            this.clientInfo1.Zip = "";
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 550);
            this.Controls.Add(this.verifyPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jobType1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stakingPage1);
            this.Controls.Add(this.selectServices1);
            this.Controls.Add(this.clientInfo1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelForm";
            this.Text = "Job Proposal Software";
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClientInfo;
        private System.Windows.Forms.Button btnSelectServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPricingPage;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnJobType;
        private ClientInfo clientInfo1;
        private JobType jobType1;
        private SelectServices selectServices1;
        private VerifyConditions verifyPage;
        private StakingPage stakingPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smartsheetOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newJobEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAccessTokeToolStripMenuItem;
    }
}