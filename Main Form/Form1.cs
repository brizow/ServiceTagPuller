using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceTagPuller
{
    public partial class Form1 : Form
    {
        //Timer countTimer = new Timer();
        //int returnTime;
        public Form1()
        {
            InitializeComponent();
            //push saved settings in to place
            adminUserNameTB.Text = ServiceTagPuller.Properties.Settings.Default.UserName;
            adminPassTB.Text = ServiceTagPuller.Properties.Settings.Default.Password;
            //get HTML text
            string curDir = Directory.GetCurrentDirectory();
            string browsercontent = File.ReadAllText(curDir + "/ResultsBody.html");
            //intialize default browser control
            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.Write(browsercontent);

            //initialize timer details
            //countTimer.Interval = (1000); //1 second
            //countTimer.Tick += new EventHandler(countTimer_Tick);
            //old stuff
            //string curDir = Directory.GetCurrentDirectory();
            //Uri NavigateTo = new Uri(String.Format("file:///{0}/ResultsBody.html", curDir));
            //this.webBrowser1.Navigate(NavigateTo);
        }

        private void FindItbtn_Click(object sender, EventArgs e)
        {
            //this is not the way to utilize this.
            //I think I need to put this in a background worker, call completion, update time. 
            //However, the browser object on the form does not like being put in a bg worker.
            //I need to spend more time on this later.
            //countTimer.Start();

            //my cheap method to show something is happening beyond Not Responding. 
            //Trying to use background workers with browsers elements requires a bit
            //more programming. Let it go non responding, we are the only folks using it.
            FindItbtn.Enabled = false;

            //declare variables
            string user;
            string pass;
            string comp;
            string command;

            //fill them
            user = adminUserNameTB.Text;
            pass = adminPassTB.Text;
            comp = @"""" + compNameSearchTB.Text + @"""";


            try
            {
                if (serialNumCB.Checked)
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                    //find serial number command
                    command = "wmic /user:" + user + " /password:" + pass + " /node:" + comp + " csproduct get vendor, name, identifyingnumber /format:htable";
                    ///format:htable - Displays a pretty preformatted table for us.
                    //put it in the browser1 control in the divSerial section
                    webBrowser1.Document.GetElementById("divSerial").InnerHtml = openCommandPrompt.SendCommand(command);
                }

                if (procCB.Checked)
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                    command = "wmic /user:" + user + " /password:" + pass + " /node:" + comp + " cpu get Name /format:htable";
                    webBrowser1.Document.GetElementById("divCPU").InnerHtml = openCommandPrompt.SendCommand(command);
                }

                if (ramCB.Checked)
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                    command = "wmic /user:" + user + " /password:" + pass + " /node:" + comp + " memorychip get capacity /format:htable";
                    webBrowser1.Document.GetElementById("divRAM").InnerHtml = openCommandPrompt.SendCommand(command);
                }

                if (osInfoCB.Checked)
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                    command = "wmic /user:" + user + " /password:" + pass + " /node:" + comp + " os get SerialNumber, OSArchitecture, Caption /format:htable";
                    webBrowser1.Document.GetElementById("divOS").InnerHtml = openCommandPrompt.SendCommand(command);
                }
                if (currUserCB.Checked)
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                    command = "wmic /user:" + user + " /password:" + pass + " /node:" + comp + " computersystem get UserName, Name /format:htable";
                    webBrowser1.Document.GetElementById("divUser").InnerHtml = openCommandPrompt.SendCommand(command);
                }
                //countTimer.Stop();
                FindItbtn.Enabled = true;
                //returnResultsLbl.Text = "Results Returned in: " + returnTime.ToString() + " seconds";
            }
            catch
            {
                //countTimer.Stop();
                webBrowser1.Document.GetElementById("divSerial").InnerHtml = "That machine does not seem to be responding to this request.";
                returnResultsLbl.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save the user and pass info on application exit
            ServiceTagPuller.Properties.Settings.Default.UserName = adminUserNameTB.Text;
            ServiceTagPuller.Properties.Settings.Default.Password = adminPassTB.Text;
            ServiceTagPuller.Properties.Settings.Default.Save();
        }

        private void saveCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save the current username and password manually
            ServiceTagPuller.Properties.Settings.Default.UserName = adminUserNameTB.Text;
            ServiceTagPuller.Properties.Settings.Default.Password = adminPassTB.Text;
            ServiceTagPuller.Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            //returnTime++;
        }
    }
}
