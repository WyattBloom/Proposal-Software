namespace JobEnter
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.boxToAddress = new System.Windows.Forms.TextBox();
            this.boxSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.boxAttach1 = new System.Windows.Forms.TextBox();
            this.boxAttach2 = new System.Windows.Forms.TextBox();
            this.btnAttach1 = new System.Windows.Forms.Button();
            this.btnAttachment2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TO ADDRESS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // boxToAddress
            // 
            this.boxToAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxToAddress.Location = new System.Drawing.Point(214, 69);
            this.boxToAddress.Margin = new System.Windows.Forms.Padding(5);
            this.boxToAddress.Name = "boxToAddress";
            this.boxToAddress.Size = new System.Drawing.Size(429, 29);
            this.boxToAddress.TabIndex = 1;
            // 
            // boxSubject
            // 
            this.boxSubject.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSubject.Location = new System.Drawing.Point(214, 121);
            this.boxSubject.Margin = new System.Windows.Forms.Padding(5);
            this.boxSubject.Name = "boxSubject";
            this.boxSubject.Size = new System.Drawing.Size(429, 29);
            this.boxSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUBJECT:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "BODY:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // boxBody
            // 
            this.boxBody.Location = new System.Drawing.Point(214, 171);
            this.boxBody.Name = "boxBody";
            this.boxBody.Size = new System.Drawing.Size(429, 163);
            this.boxBody.TabIndex = 6;
            this.boxBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSend.Location = new System.Drawing.Point(304, 465);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(132, 56);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxAttach1
            // 
            this.boxAttach1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAttach1.Location = new System.Drawing.Point(214, 347);
            this.boxAttach1.Margin = new System.Windows.Forms.Padding(5);
            this.boxAttach1.Name = "boxAttach1";
            this.boxAttach1.Size = new System.Drawing.Size(429, 29);
            this.boxAttach1.TabIndex = 9;
            // 
            // boxAttach2
            // 
            this.boxAttach2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAttach2.Location = new System.Drawing.Point(212, 398);
            this.boxAttach2.Margin = new System.Windows.Forms.Padding(5);
            this.boxAttach2.Name = "boxAttach2";
            this.boxAttach2.Size = new System.Drawing.Size(429, 29);
            this.boxAttach2.TabIndex = 11;
            // 
            // btnAttach1
            // 
            this.btnAttach1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach1.Location = new System.Drawing.Point(71, 347);
            this.btnAttach1.Name = "btnAttach1";
            this.btnAttach1.Size = new System.Drawing.Size(133, 34);
            this.btnAttach1.TabIndex = 12;
            this.btnAttach1.Text = "Attachment 1";
            this.btnAttach1.UseVisualStyleBackColor = true;
            this.btnAttach1.Click += new System.EventHandler(this.btnAttach1_Click);
            // 
            // btnAttachment2
            // 
            this.btnAttachment2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachment2.Location = new System.Drawing.Point(76, 398);
            this.btnAttachment2.Name = "btnAttachment2";
            this.btnAttachment2.Size = new System.Drawing.Size(128, 34);
            this.btnAttachment2.TabIndex = 13;
            this.btnAttachment2.Text = "Attachment 2";
            this.btnAttachment2.UseVisualStyleBackColor = true;
            this.btnAttachment2.Click += new System.EventHandler(this.btnAttachment2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 610);
            this.Controls.Add(this.btnAttachment2);
            this.Controls.Add(this.btnAttach1);
            this.Controls.Add(this.boxAttach2);
            this.Controls.Add(this.boxAttach1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.boxBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxToAddress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxToAddress;
        private System.Windows.Forms.TextBox boxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox boxBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox boxAttach1;
        private System.Windows.Forms.TextBox boxAttach2;
        private System.Windows.Forms.Button btnAttach1;
        private System.Windows.Forms.Button btnAttachment2;
    }
}