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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPricingPage = new FontAwesome.Sharp.IconButton();
            this.btnSelectServices = new FontAwesome.Sharp.IconButton();
            this.btnJobType = new FontAwesome.Sharp.IconButton();
            this.btnClientInfo = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelCurrentHeader = new System.Windows.Forms.Panel();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.icoCurrentBox = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jobType1 = new JobEnter.JobType();
            this.clientInfo1 = new JobEnter.ClientInfo();
            this.stakingPage1 = new JobEnter.StakingPage();
            this.selectServices1 = new JobEnter.SelectServices();
            this.verifyPage = new JobEnter.VerifyConditions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelCurrentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoCurrentBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(97, 12);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(213, 47);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(318, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(213, 47);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnPricingPage);
            this.panelMenu.Controls.Add(this.btnSelectServices);
            this.panelMenu.Controls.Add(this.btnJobType);
            this.panelMenu.Controls.Add(this.btnClientInfo);
            this.panelMenu.Controls.Add(this.iconPictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 696);
            this.panelMenu.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.newJobEntryToolStripMenuItem_Click);
            // 
            // btnPricingPage
            // 
            this.btnPricingPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPricingPage.FlatAppearance.BorderSize = 0;
            this.btnPricingPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricingPage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPricingPage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricingPage.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPricingPage.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnPricingPage.IconColor = System.Drawing.Color.White;
            this.btnPricingPage.IconSize = 40;
            this.btnPricingPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPricingPage.Location = new System.Drawing.Point(0, 344);
            this.btnPricingPage.Name = "btnPricingPage";
            this.btnPricingPage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPricingPage.Rotation = 0D;
            this.btnPricingPage.Size = new System.Drawing.Size(220, 80);
            this.btnPricingPage.TabIndex = 4;
            this.btnPricingPage.Text = "Enter Pricing";
            this.btnPricingPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPricingPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPricingPage.UseVisualStyleBackColor = true;
            this.btnPricingPage.Click += new System.EventHandler(this.btnPricingPage_Click);
            // 
            // btnSelectServices
            // 
            this.btnSelectServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectServices.FlatAppearance.BorderSize = 0;
            this.btnSelectServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectServices.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSelectServices.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectServices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelectServices.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnSelectServices.IconColor = System.Drawing.Color.White;
            this.btnSelectServices.IconSize = 40;
            this.btnSelectServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectServices.Location = new System.Drawing.Point(0, 264);
            this.btnSelectServices.Name = "btnSelectServices";
            this.btnSelectServices.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSelectServices.Rotation = 0D;
            this.btnSelectServices.Size = new System.Drawing.Size(220, 80);
            this.btnSelectServices.TabIndex = 3;
            this.btnSelectServices.Text = "Select Services";
            this.btnSelectServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectServices.UseVisualStyleBackColor = true;
            this.btnSelectServices.Click += new System.EventHandler(this.btnSelectServices_Click);
            // 
            // btnJobType
            // 
            this.btnJobType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobType.FlatAppearance.BorderSize = 0;
            this.btnJobType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobType.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnJobType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnJobType.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnJobType.IconColor = System.Drawing.Color.White;
            this.btnJobType.IconSize = 40;
            this.btnJobType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobType.Location = new System.Drawing.Point(0, 184);
            this.btnJobType.Name = "btnJobType";
            this.btnJobType.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnJobType.Rotation = 0D;
            this.btnJobType.Size = new System.Drawing.Size(220, 80);
            this.btnJobType.TabIndex = 2;
            this.btnJobType.Text = "Select Job Type";
            this.btnJobType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJobType.UseVisualStyleBackColor = true;
            this.btnJobType.Click += new System.EventHandler(this.btnJobType_Click);
            // 
            // btnClientInfo
            // 
            this.btnClientInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientInfo.FlatAppearance.BorderSize = 0;
            this.btnClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClientInfo.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnClientInfo.IconColor = System.Drawing.Color.White;
            this.btnClientInfo.IconSize = 40;
            this.btnClientInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientInfo.Location = new System.Drawing.Point(0, 104);
            this.btnClientInfo.Name = "btnClientInfo";
            this.btnClientInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClientInfo.Rotation = 0D;
            this.btnClientInfo.Size = new System.Drawing.Size(220, 80);
            this.btnClientInfo.TabIndex = 1;
            this.btnClientInfo.Text = "Enter Client Info";
            this.btnClientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientInfo.UseVisualStyleBackColor = true;
            this.btnClientInfo.Click += new System.EventHandler(this.btnClientInfo_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 104;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(220, 104);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelCurrentHeader
            // 
            this.panelCurrentHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.panelCurrentHeader.Controls.Add(this.btnMaximize);
            this.panelCurrentHeader.Controls.Add(this.btnMinimize);
            this.panelCurrentHeader.Controls.Add(this.btnClose);
            this.panelCurrentHeader.Controls.Add(this.lblCurrentPage);
            this.panelCurrentHeader.Controls.Add(this.icoCurrentBox);
            this.panelCurrentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentHeader.Location = new System.Drawing.Point(220, 0);
            this.panelCurrentHeader.Name = "panelCurrentHeader";
            this.panelCurrentHeader.Size = new System.Drawing.Size(1049, 70);
            this.panelCurrentHeader.TabIndex = 36;
            this.panelCurrentHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCurrentHeader_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(953, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(45, 27);
            this.btnMaximize.TabIndex = 40;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(908, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(45, 27);
            this.btnMinimize.TabIndex = 39;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(998, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0D;
            this.btnClose.Size = new System.Drawing.Size(45, 27);
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPage.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPage.Location = new System.Drawing.Point(52, 31);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(60, 22);
            this.lblCurrentPage.TabIndex = 38;
            this.lblCurrentPage.Text = "label1";
            // 
            // icoCurrentBox
            // 
            this.icoCurrentBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(191)))));
            this.icoCurrentBox.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icoCurrentBox.IconColor = System.Drawing.Color.White;
            this.icoCurrentBox.IconSize = 40;
            this.icoCurrentBox.Location = new System.Drawing.Point(6, 22);
            this.icoCurrentBox.Name = "icoCurrentBox";
            this.icoCurrentBox.Size = new System.Drawing.Size(40, 40);
            this.icoCurrentBox.TabIndex = 0;
            this.icoCurrentBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(220, 631);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 65);
            this.panel2.TabIndex = 37;
            // 
            // jobType1
            // 
            this.jobType1.BackColor = System.Drawing.SystemColors.Control;
            this.jobType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobType1.Location = new System.Drawing.Point(10, 10);
            this.jobType1.Margin = new System.Windows.Forms.Padding(7, 8, 2, 2);
            this.jobType1.Name = "jobType1";
            this.jobType1.Size = new System.Drawing.Size(1039, 551);
            this.jobType1.TabIndex = 30;
            this.jobType1.Visible = false;
            // 
            // clientInfo1
            // 
            this.clientInfo1.Address = "";
            this.clientInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientInfo1.City = "";
            this.clientInfo1.CountyBox = "";
            this.clientInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientInfo1.Email = "";
            this.clientInfo1.Location = new System.Drawing.Point(10, 10);
            this.clientInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.clientInfo1.Name = "clientInfo1";
            this.clientInfo1.Number = "";
            this.clientInfo1.Size = new System.Drawing.Size(1039, 551);
            this.clientInfo1.SpecialInstructions = "";
            this.clientInfo1.TabIndex = 29;
            // 
            // stakingPage1
            // 
            this.stakingPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stakingPage1.Corner = "";
            this.stakingPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stakingPage1.Location = new System.Drawing.Point(10, 10);
            this.stakingPage1.Margin = new System.Windows.Forms.Padding(2);
            this.stakingPage1.Name = "stakingPage1";
            this.stakingPage1.Size = new System.Drawing.Size(1039, 551);
            this.stakingPage1.STKPRice = "";
            this.stakingPage1.TabIndex = 33;
            this.stakingPage1.Visible = false;
            // 
            // selectServices1
            // 
            this.selectServices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectServices1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectServices1.Location = new System.Drawing.Point(10, 10);
            this.selectServices1.Margin = new System.Windows.Forms.Padding(2);
            this.selectServices1.Name = "selectServices1";
            this.selectServices1.Size = new System.Drawing.Size(1039, 551);
            this.selectServices1.TabIndex = 31;
            this.selectServices1.Visible = false;
            // 
            // verifyPage
            // 
            this.verifyPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verifyPage.Days = "";
            this.verifyPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verifyPage.Location = new System.Drawing.Point(10, 10);
            this.verifyPage.Margin = new System.Windows.Forms.Padding(2);
            this.verifyPage.Name = "verifyPage";
            this.verifyPage.Price = "";
            this.verifyPage.Size = new System.Drawing.Size(1039, 551);
            this.verifyPage.StakePrice = "";
            this.verifyPage.TabIndex = 32;
            this.verifyPage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.selectServices1);
            this.panel1.Controls.Add(this.stakingPage1);
            this.panel1.Controls.Add(this.clientInfo1);
            this.panel1.Controls.Add(this.verifyPage);
            this.panel1.Controls.Add(this.jobType1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 70);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1049, 561);
            this.panel1.TabIndex = 38;
            // 
            // PanelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCurrentHeader);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Proposal Software";
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelCurrentHeader.ResumeLayout(false);
            this.panelCurrentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoCurrentBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
        private ClientInfo clientInfo1;
        private JobType jobType1;
        private SelectServices selectServices1;
        private VerifyConditions verifyPage;
        private StakingPage stakingPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnPricingPage;
        private FontAwesome.Sharp.IconButton btnSelectServices;
        private FontAwesome.Sharp.IconButton btnJobType;
        private FontAwesome.Sharp.IconButton btnClientInfo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelCurrentHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentPage;
        private FontAwesome.Sharp.IconPictureBox icoCurrentBox;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panel1;
    }
}