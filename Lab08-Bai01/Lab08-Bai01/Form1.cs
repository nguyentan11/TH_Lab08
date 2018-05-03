using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Lab08_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMail(txtSender.Text, txtTo.Text, txtSubject.Text, txtContent.Text);
        }
        public void SendMail(string from, string to, string subject, string message)
        {
            MailMessage mess = new MailMessage(txtSender.Text, txtTo.Text, txtSubject.Text, txtContent.Text);
            SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
            mailclient.EnableSsl = true;
            mailclient.Credentials = new NetworkCredential(txtSender.Text, txtPassword.Text);
            mailclient.Send(mess);
            MessageBox.Show("Mail sent successfully!");
        }
    }
}
