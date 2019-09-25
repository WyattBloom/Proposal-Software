using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace JobEnter
{
    class SendEmail
    {
        private string toAddress = "";
        private string cc = "";
        private string subject = "";
        private string body = "";
        private string attach1 = "";
        private string attach2 = "";


        public SendEmail(string toAddress, string cc, string subject, string body, string attach1, string attach2)
        {
            this.toAddress = toAddress;
            this.cc = cc;
            this.subject = subject;
            this.body = body;
            this.attach1 = attach1;
            this.attach2 = attach2;
        }

        public string changeToAddress { get{ return toAddress; } set { toAddress = value; } }
        public string changeCC { get { return cc; } set { cc= value; } }
        public string changeSubject { get { return subject; } set { subject= value; } }
        public string changeBody { get { return body; } set { body= value; } }
        public string changeAttach1 { get { return attach1; } set { attach1= value; } }
        public string changeAttach2 { get { return attach2; } set { attach2 = value; } }

        /*
        * Uses the email and opens an outlook window with subject, body, to address, and attachments 
        * filled in. 
        */
        public void openOutlookWindow()
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = toAddress;
            oMailItem.Subject = subject;
            oMailItem.Body = body;
            oMailItem.CC = cc;
            if (attach1 != null)
                oMailItem.Attachments.Add(attach1);
            if (attach2 != null)
                oMailItem.Attachments.Add(attach2);
            oMailItem.Display(true);
        }

    }
}
