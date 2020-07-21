﻿namespace JobEnter
{
    partial class SelectServices
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnFullTopo = new System.Windows.Forms.Button();
            this.btnFullLake = new System.Windows.Forms.Button();
            this.btnFullHC = new System.Windows.Forms.Button();
            this.btnFullWetland = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 10;
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 39);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(1004, 469);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Services:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(631, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "City:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(713, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(917, 543);
            this.btnUncheckAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(100, 28);
            this.btnUncheckAll.TabIndex = 7;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(12, 543);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(100, 28);
            this.btnCheckAll.TabIndex = 8;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFullTopo
            // 
            this.btnFullTopo.Location = new System.Drawing.Point(1024, 71);
            this.btnFullTopo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFullTopo.Name = "btnFullTopo";
            this.btnFullTopo.Size = new System.Drawing.Size(100, 28);
            this.btnFullTopo.TabIndex = 9;
            this.btnFullTopo.Text = "Full Topo";
            this.btnFullTopo.UseVisualStyleBackColor = true;
            this.btnFullTopo.Click += new System.EventHandler(this.btnFullTopo_Click);
            // 
            // btnFullLake
            // 
            this.btnFullLake.Location = new System.Drawing.Point(1024, 107);
            this.btnFullLake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFullLake.Name = "btnFullLake";
            this.btnFullLake.Size = new System.Drawing.Size(100, 28);
            this.btnFullLake.TabIndex = 10;
            this.btnFullLake.Text = "Full On Lake";
            this.btnFullLake.UseVisualStyleBackColor = true;
            this.btnFullLake.Click += new System.EventHandler(this.btnFullLake_Click);
            // 
            // btnFullHC
            // 
            this.btnFullHC.Location = new System.Drawing.Point(1024, 143);
            this.btnFullHC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFullHC.Name = "btnFullHC";
            this.btnFullHC.Size = new System.Drawing.Size(100, 28);
            this.btnFullHC.TabIndex = 11;
            this.btnFullHC.Text = "Full HC";
            this.btnFullHC.UseVisualStyleBackColor = true;
            this.btnFullHC.Click += new System.EventHandler(this.btnFullHC_Click);
            // 
            // btnFullWetland
            // 
            this.btnFullWetland.Location = new System.Drawing.Point(1024, 178);
            this.btnFullWetland.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFullWetland.Name = "btnFullWetland";
            this.btnFullWetland.Size = new System.Drawing.Size(100, 28);
            this.btnFullWetland.TabIndex = 12;
            this.btnFullWetland.Text = "Full Wetland";
            this.btnFullWetland.UseVisualStyleBackColor = true;
            this.btnFullWetland.Click += new System.EventHandler(this.btnFullWetland_Click);
            // 
            // SelectServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFullWetland);
            this.Controls.Add(this.btnFullHC);
            this.Controls.Add(this.btnFullLake);
            this.Controls.Add(this.btnFullTopo);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectServices";
            this.Size = new System.Drawing.Size(1140, 585);
            this.Load += new System.EventHandler(this.NewHomeServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnFullTopo;
        private System.Windows.Forms.Button btnFullLake;
        private System.Windows.Forms.Button btnFullHC;
        private System.Windows.Forms.Button btnFullWetland;
    }
}
