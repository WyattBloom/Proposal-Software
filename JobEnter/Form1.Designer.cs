namespace JobEnter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxSide = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnProposedConditions = new System.Windows.Forms.Button();
            this.cmbBoxExisting = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.boxStakePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExistingCondition = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.boxInstructions = new System.Windows.Forms.RichTextBox();
            this.boxCorner = new System.Windows.Forms.TextBox();
            this.lblCorner = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.rbtnExisting = new System.Windows.Forms.RadioButton();
            this.rbtnProposed = new System.Windows.Forms.RadioButton();
            this.rbtnTwo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.updateAPI = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxSide
            // 
            this.boxSide.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSide.Location = new System.Drawing.Point(193, 329);
            this.boxSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSide.Name = "boxSide";
            this.boxSide.Size = new System.Drawing.Size(540, 29);
            this.boxSide.TabIndex = 0;
            this.boxSide.Visible = false;
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxName.Location = new System.Drawing.Point(197, 32);
            this.boxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(536, 30);
            this.boxName.TabIndex = 0;
            // 
            // boxAddress
            // 
            this.boxAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAddress.Location = new System.Drawing.Point(197, 73);
            this.boxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(536, 30);
            this.boxAddress.TabIndex = 1;
            // 
            // boxPhone
            // 
            this.boxPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPhone.Location = new System.Drawing.Point(197, 112);
            this.boxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(536, 30);
            this.boxPhone.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 31);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Client Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 31);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(8, 112);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(184, 31);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(8, 325);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(153, 31);
            this.lblSide.TabIndex = 7;
            this.lblSide.Text = "Which Side?";
            this.lblSide.Visible = false;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(12, 92);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(137, 35);
            this.rbtnAll.TabIndex = 2;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All Stake";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnOne
            // 
            this.rbtnOne.AutoSize = true;
            this.rbtnOne.Location = new System.Drawing.Point(12, 16);
            this.rbtnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.Size = new System.Drawing.Size(147, 35);
            this.rbtnOne.TabIndex = 0;
            this.rbtnOne.TabStop = true;
            this.rbtnOne.Text = "One Stake";
            this.rbtnOne.UseVisualStyleBackColor = true;
            this.rbtnOne.CheckedChanged += new System.EventHandler(this.rbtnOne_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnAddition);
            this.groupBox1.Controls.Add(this.btnProposedConditions);
            this.groupBox1.Controls.Add(this.cmbBoxExisting);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.boxStakePrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnExistingCondition);
            this.groupBox1.Controls.Add(this.lblInstructions);
            this.groupBox1.Controls.Add(this.boxInstructions);
            this.groupBox1.Controls.Add(this.boxCorner);
            this.groupBox1.Controls.Add(this.lblCorner);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.boxEmail);
            this.groupBox1.Controls.Add(this.boxSide);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Controls.Add(this.boxAddress);
            this.groupBox1.Controls.Add(this.boxPhone);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblSide);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(327, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1356, 474);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddition.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.Location = new System.Drawing.Point(13, 366);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(723, 81);
            this.btnAddition.TabIndex = 29;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Visible = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnProposedConditions
            // 
            this.btnProposedConditions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProposedConditions.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProposedConditions.Location = new System.Drawing.Point(13, 366);
            this.btnProposedConditions.Margin = new System.Windows.Forms.Padding(4);
            this.btnProposedConditions.Name = "btnProposedConditions";
            this.btnProposedConditions.Size = new System.Drawing.Size(724, 81);
            this.btnProposedConditions.TabIndex = 28;
            this.btnProposedConditions.Text = "Proposed Conditions";
            this.btnProposedConditions.UseVisualStyleBackColor = false;
            this.btnProposedConditions.Visible = false;
            this.btnProposedConditions.Click += new System.EventHandler(this.btnProposedConditions_Click);
            // 
            // cmbBoxExisting
            // 
            this.cmbBoxExisting.FormattingEnabled = true;
            this.cmbBoxExisting.Items.AddRange(new object[] {
            "Minneapolis",
            "Edina"});
            this.cmbBoxExisting.Location = new System.Drawing.Point(432, 229);
            this.cmbBoxExisting.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxExisting.Name = "cmbBoxExisting";
            this.cmbBoxExisting.Size = new System.Drawing.Size(301, 29);
            this.cmbBoxExisting.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "City:";
            // 
            // boxPrice
            // 
            this.boxPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPrice.Location = new System.Drawing.Point(197, 231);
            this.boxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(152, 30);
            this.boxPrice.TabIndex = 25;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(8, 238);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 31);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Price:";
            // 
            // boxStakePrice
            // 
            this.boxStakePrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStakePrice.Location = new System.Drawing.Point(193, 284);
            this.boxStakePrice.Margin = new System.Windows.Forms.Padding(4);
            this.boxStakePrice.Name = "boxStakePrice";
            this.boxStakePrice.Size = new System.Drawing.Size(540, 30);
            this.boxStakePrice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Stake Price:";
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Location = new System.Drawing.Point(197, 191);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(536, 30);
            this.txtDays.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Days Estimate:";
            // 
            // btnExistingCondition
            // 
            this.btnExistingCondition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExistingCondition.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingCondition.Location = new System.Drawing.Point(13, 366);
            this.btnExistingCondition.Margin = new System.Windows.Forms.Padding(4);
            this.btnExistingCondition.Name = "btnExistingCondition";
            this.btnExistingCondition.Size = new System.Drawing.Size(724, 81);
            this.btnExistingCondition.TabIndex = 12;
            this.btnExistingCondition.Text = "Existing Conditions";
            this.btnExistingCondition.UseVisualStyleBackColor = false;
            this.btnExistingCondition.Visible = false;
            this.btnExistingCondition.Click += new System.EventHandler(this.btnExistingCondition_Click_1);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(759, 31);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(206, 27);
            this.lblInstructions.TabIndex = 19;
            this.lblInstructions.Text = "Special Instructions:";
            // 
            // boxInstructions
            // 
            this.boxInstructions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInstructions.Location = new System.Drawing.Point(764, 63);
            this.boxInstructions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxInstructions.Name = "boxInstructions";
            this.boxInstructions.Size = new System.Drawing.Size(572, 383);
            this.boxInstructions.TabIndex = 4;
            this.boxInstructions.Text = "";
            // 
            // boxCorner
            // 
            this.boxCorner.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCorner.Location = new System.Drawing.Point(193, 329);
            this.boxCorner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCorner.Name = "boxCorner";
            this.boxCorner.Size = new System.Drawing.Size(540, 29);
            this.boxCorner.TabIndex = 18;
            this.boxCorner.Visible = false;
            // 
            // lblCorner
            // 
            this.lblCorner.AutoSize = true;
            this.lblCorner.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorner.Location = new System.Drawing.Point(8, 325);
            this.lblCorner.Name = "lblCorner";
            this.lblCorner.Size = new System.Drawing.Size(181, 31);
            this.lblCorner.TabIndex = 17;
            this.lblCorner.Text = "Which Corner?";
            this.lblCorner.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 366);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(724, 81);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 31);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // boxEmail
            // 
            this.boxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEmail.Location = new System.Drawing.Point(197, 153);
            this.boxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(536, 30);
            this.boxEmail.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnAddition);
            this.panel1.Controls.Add(this.rbtnExisting);
            this.panel1.Controls.Add(this.rbtnProposed);
            this.panel1.Controls.Add(this.rbtnOne);
            this.panel1.Controls.Add(this.rbtnTwo);
            this.panel1.Controls.Add(this.rbtnAll);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 261);
            this.panel1.TabIndex = 12;
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Location = new System.Drawing.Point(12, 207);
            this.rbtnAddition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(132, 35);
            this.rbtnAddition.TabIndex = 2;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "Addition";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            this.rbtnAddition.CheckedChanged += new System.EventHandler(this.RbtnAddition_CheckedChanged);
            // 
            // rbtnExisting
            // 
            this.rbtnExisting.AutoSize = true;
            this.rbtnExisting.Location = new System.Drawing.Point(12, 169);
            this.rbtnExisting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnExisting.Name = "rbtnExisting";
            this.rbtnExisting.Size = new System.Drawing.Size(123, 35);
            this.rbtnExisting.TabIndex = 1;
            this.rbtnExisting.TabStop = true;
            this.rbtnExisting.Text = "Existing";
            this.rbtnExisting.UseVisualStyleBackColor = true;
            this.rbtnExisting.CheckedChanged += new System.EventHandler(this.RbtnExisting_CheckedChanged);
            // 
            // rbtnProposed
            // 
            this.rbtnProposed.AutoSize = true;
            this.rbtnProposed.Location = new System.Drawing.Point(12, 130);
            this.rbtnProposed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnProposed.Name = "rbtnProposed";
            this.rbtnProposed.Size = new System.Drawing.Size(137, 35);
            this.rbtnProposed.TabIndex = 0;
            this.rbtnProposed.TabStop = true;
            this.rbtnProposed.Text = "Proposed";
            this.rbtnProposed.UseVisualStyleBackColor = true;
            this.rbtnProposed.CheckedChanged += new System.EventHandler(this.RbtnProposed_CheckedChanged);
            // 
            // rbtnTwo
            // 
            this.rbtnTwo.AutoSize = true;
            this.rbtnTwo.Location = new System.Drawing.Point(12, 54);
            this.rbtnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnTwo.Name = "rbtnTwo";
            this.rbtnTwo.Size = new System.Drawing.Size(149, 35);
            this.rbtnTwo.TabIndex = 1;
            this.rbtnTwo.TabStop = true;
            this.rbtnTwo.Text = "Two Stake";
            this.rbtnTwo.UseVisualStyleBackColor = true;
            this.rbtnTwo.CheckedChanged += new System.EventHandler(this.rbtnTwo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1716, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 81);
            this.button1.TabIndex = 25;
            this.button1.Text = "Send Email";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1820, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1819, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1709, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Directory:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1709, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Path:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1819, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1709, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "FileInFolder:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1819, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1709, 284);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "FileOnDesk:";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1819, 284);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1711, 318);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "PDFFileName:";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1819, 318);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1711, 337);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "PDFInFolder:";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1819, 337);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "label16";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.Location = new System.Drawing.Point(33, 41);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(223, 29);
            this.lblStep1.TabIndex = 26;
            this.lblStep1.Text = "Choose a Job Type";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.Location = new System.Drawing.Point(328, 41);
            this.lblStep2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(263, 29);
            this.lblStep2.TabIndex = 27;
            this.lblStep2.Text = "Enter Client Information";
            // 
            // updateAPI
            // 
            this.updateAPI.Location = new System.Drawing.Point(97, 413);
            this.updateAPI.Name = "updateAPI";
            this.updateAPI.Size = new System.Drawing.Size(115, 48);
            this.updateAPI.TabIndex = 28;
            this.updateAPI.Text = "Send API";
            this.updateAPI.UseVisualStyleBackColor = true;
            this.updateAPI.Click += new System.EventHandler(this.updateAPI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1723, 564);
            this.Controls.Add(this.updateAPI);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Client Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxSide;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxCorner;
        private System.Windows.Forms.Label lblCorner;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.RichTextBox boxInstructions;
        private System.Windows.Forms.RadioButton rbtnTwo;
        private System.Windows.Forms.Button btnExistingCondition;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxStakePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbBoxExisting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbtnProposed;
        private System.Windows.Forms.RadioButton rbtnExisting;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.Button btnProposedConditions;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button updateAPI;
    }
}

