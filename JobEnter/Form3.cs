using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Deployment.Application;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Net;
using System.Net.Mail;
using System.Windows.Input;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace JobEnter
{
    public partial class Form3 : Form
    {

        string pdfLocation = "";
        string email = "";
        string subject = "";
        string fileName = "";

        public Form3(string pdfLocation, string email, string subject)
        {
            InitializeComponent();
            this.pdfLocation = pdfLocation;
            this.email = email;
            this.subject = subject;
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            boxToAddress.Text = email;
            boxAttach1.Text = pdfLocation;
            boxSubject.Text = subject;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Outlook.Application _app = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                mail.To = boxToAddress.Text;
                mail.Subject = boxSubject.Text;
                mail.Body = boxBody.Text;
                mail.Importance = Outlook.OlImportance.olImportanceNormal;
                ((Outlook._MailItem)mail).Send();
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                mail.Attachments.Add(
                fileName,
                Outlook.OlAttachmentType.olByValue,
                1,
                fileName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            string from = "wyattspam18@gmail.com";
            string to = boxToAddress.Text;
            string subject = boxSubject.Text;
            string body = boxBody.Text;
            string userName = "wyattbloom10@hotmail.com";
            string password = "ihave2dogs";
            //wyattspam18@gmail.com
            //NDSU2021

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.live.com", 587);
            client.Credentials = new System.Net.NetworkCredential(userName, password);
            client.EnableSsl = true;
            if(boxAttach1.Text != "")
                mail.Attachments.Add(new Attachment(boxAttach1.Text));
            if (boxAttach2.Text != "")
                mail.Attachments.Add(new Attachment(boxAttach2.Text));

            //smtp.gmail.com
            try
            {
                client.Send(mail);
                MessageBox.Show("Message Succesfully Sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btnAttach1_Click(object sender, EventArgs e)
        {
            fileName = getFile();
        }
        private string getFile()
        {
            OpenFileDialog dg = new OpenFileDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                string path = dg.FileName.ToString();
                boxAttach1.Text = path;
            }
            return dg.FileName.ToString();
        }

        private void btnAttachment2_Click(object sender, EventArgs e)
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = boxToAddress.Text;
            oMailItem.Subject = boxSubject.Text;
            oMailItem.Body = boxBody.Text;
            if(boxAttach1.Text != "")
                oMailItem.Attachments.Add(boxAttach1.Text);
            oMailItem.Display(true);

        }
    }
}
