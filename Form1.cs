using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Script_Hub_Uploader_Beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * FOR EDUCATIONAL PURPOSE AND DEMO ONLY
         * 
         * Created by SkieHacker ( because He is lazy adding his own things one by one, so he made an automation thingy )
         * 
         */


        private void Parsing()
        {

            string ohkay = header1.Text + titlebox.Text + header2.Text + imageurl.Text + header3.Text + scripturl.Text + header4.Text + ",";
            printoutput.AppendText("\n" + ohkay);


        }

        private void Info(string lol)
        {
            ConsoleLog.AppendText("\n[ Client Log ] " + lol);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Parsing();
            Info("Adding New Script");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            /*
             * 
             * 
             * So i don't document this properly, learn if by yourself. Some code are on richtextbox because i can't put here, well you can just find those and replace it with yours /shrug
             * so i made this quickly, try to learn to this one, uhh yeah i know you can do it unless ur stupid skid
             * 
             * oh btw after you build this thing, do not release it to anyone as it may given you risk to your FTP Credential ( unless you rewrite this or sort )
             * have a good day mam / sir
             * 
             * 
             * */
            await Task.Delay(1500);
            string owoz = richTextBox4.Text + printoutput.Text + richTextBox3.Text;
            string gaymerge = owoz.Replace(",$", " ");
            Info("Waiting for User Confirmation ( FTP Upload )");
            await Task.Delay(1500);
            DialogResult dialogResult = MessageBox.Show("Do you want to Upload this to the Server? If no, this will prompt you to Save it Local", "Notification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Info("Uploading to the Server.. Please Wait");
                await Task.Delay(1500);

                string FTP_LINK = "ftp://epiz_28590981@ftpupload.net/pandatechnology.xyz/htdocs/MyScriptHub/scripthub.json"; //Replace it with your own FTP URL Link because that's an example and it won't work with dat link if you use it, caz i change it lmao
                string FTP_USER = ""; //FTP Username
                string FTP_PASS = ""; //FTP Password
                FtpUploadString(gaymerge, FTP_LINK, FTP_USER, FTP_PASS);
            }
            else if (dialogResult == DialogResult.No)
            {
                try
                {
                    System.Windows.Forms.SaveFileDialog savefile = new System.Windows.Forms.SaveFileDialog()
                    {
                        Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*"
                    };

                    if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        File.WriteAllText(savefile.FileName, gaymerge);
                        Info("Data was saved on " + savefile.FileName);
                        Process.Start(savefile.FileName);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to Save. Lol");
                }
            }
            Info("_______________________________________________________________");
            Info("                     Operation Complete!                       ");
            Info("_______________________________________________________________");


        }

        //Credit to Stackoverflow xD
        private void FtpUploadString(string text, string to_uri,
    string user_name, string password)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(to_uri);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(user_name, password);
            request.ContentLength = text.Length;
            using (Stream request_stream = request.GetRequestStream())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                request_stream.Write(bytes, 0, text.Length);
                request_stream.Close();
                Info("Upload String Complete");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
