using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Linq;
using System.Diagnostics;

namespace ServiceTagPuller
{
    public partial class Form1 : Form
    {
        //declare variables
        string user;
        string pass;
        string comp;
        string command;
        string osInfo;

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

            //turn on AutColumnGeneration
            dataGridView1.AutoGenerateColumns = true;
        }

        #region SinglePCTab

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
            //FindItbtn.Enabled = false;

            //fill variables them
            user = adminUserNameTB.Text;
            pass = adminPassTB.Text;
            comp = @"""" + compNameSearchTB.Text + @"""";
            getInfoSingle(user, pass, comp);
        }

        private void getInfoSingle(string username, string password, string computer)
        {
            if (compNameSearchTB.Text != "")
            {
                try
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

                    //see if the machine is up
                    command = "ping " + comp;
                    var isItUp = openCommandPrompt.SendCommand(command);

                    if (isItUp.Contains("Request timed out."))
                    {
                        webBrowser1.Document.GetElementById("divSerial").InnerHtml = "This computer does not appear to be on.";
                    }
                    else if (isItUp.Contains("Ping request could not find host"))
                    {
                        webBrowser1.Document.GetElementById("divSerial").InnerHtml = "This computer name does not exist.";
                    }
                    else
                    {
                        try
                        {
                            if (serialNumCB.Checked)
                            { 
                                //find serial number command
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " csproduct get vendor, name, identifyingnumber /format:htable";
                                ///format:htable - Displays a pretty preformatted table for us.
                                //put it in the browser1 control in the divSerial section
                                webBrowser1.Document.GetElementById("divSerial").InnerHtml = openCommandPrompt.SendCommand(command);
                            }

                            if (procCB.Checked)
                            {
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " cpu get Name /format:htable";
                                webBrowser1.Document.GetElementById("divCPU").InnerHtml = openCommandPrompt.SendCommand(command);
                            }

                            if (ramCB.Checked)
                            {
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " memorychip get capacity /format:htable";
                                webBrowser1.Document.GetElementById("divRAM").InnerHtml = openCommandPrompt.SendCommand(command);
                            }

                            if (hddCB.Checked)
                            {
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " diskdrive get caption /format:htable";
                                webBrowser1.Document.GetElementById("divHDD").InnerHtml = openCommandPrompt.SendCommand(command);
                            }

                            if (osInfoCB.Checked)
                            {
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " os get SerialNumber, OSArchitecture, Caption /format:htable";
                                webBrowser1.Document.GetElementById("divOS").InnerHtml = openCommandPrompt.SendCommand(command);
                                osInfo = openCommandPrompt.SendCommand(command);
                            }
                            if (currUserCB.Checked)
                            {
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " computersystem get UserName, Name /format:htable";
                                webBrowser1.Document.GetElementById("divUser").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            if (softwareCB.Checked)
                            {
                                string filter = "\"Name like '%ESET%'\"";
                                string filter2 = "\"Name like '%Adobe%'\"";
                                string filter3 = "\"Name like '%Office%'\"";

                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divAntiVirus").InnerHtml = openCommandPrompt.SendCommand(command);
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter2 + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divAdobe").InnerHtml = openCommandPrompt.SendCommand(command);
                                //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter3 + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divOffice").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                        }
                        catch (Exception ex)
                        {
                            //countTimer.Stop();
                            webBrowser1.Document.GetElementById("divSerial").InnerHtml = ex.ToString();
                            returnResultsLbl.Text = "";
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //intentionally blank
                }
            }
        }

        #endregion

        #region ToolStrip_FormOperations

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

        private void aDConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region MultiPCTab

        private void findMachineBtn_Click(object sender, EventArgs e)
        {
            getMachinesFromAD();
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            ////check all the items
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            }
        }

        private void checkForLogsBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void getDetailsBtn_Click(object sender, EventArgs e)
        {
            getInfoMulti("bwadmin", "TallGiraffe_2");
        }



        #region MyMethods

        private void checkLogs()
        {
            IList<string> returnedResults = new List<string>();

            if (listBox1.SelectedItems.Count > 0)
            {
                foreach (var item in listBox1.SelectedItems)
                {
                    //hit a remote machine, check paths
                    //pushd \\oak - dc - asstmgr\c$\Windows\Temp
                    //del cab_ * / f / a / q
                    //cd..
                    //cd Logs\CBS
                    //del CbsPersist *.* / f / a / q
                }
            }
        }

        private void returnMachineDetails()
        {
            IList<string> returnedResults = new List<string>();

            foreach (var item in listBox1.SelectedItems)
            {
                comp = item.ToString();   /*.TrimEnd('r', 'n', '/');*/
                try
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

                    //see if the machine is up
                    command = "ping " + comp;
                    var isItUp = openCommandPrompt.SendCommand(command);

                    if (isItUp.Contains("Request timed out."))
                    {
                        returnedResults.Add(comp + ": This machine appears to be off.");
                    }
                    else if (isItUp.Contains("Ping request could not find host"))
                    {
                        returnedResults.Add(comp + ": This computer does not exist.");
                    }
                    else
                    {
                        returnedResults.Add(comp + ": This computer is up.");
                    }
                }
                catch
                {

                }
            }
            //add items to the grid view
            dataGridView1.DataSource = returnedResults.Select(x => new { Value = x }).ToList();


            #endregion
        }

        private void getMachinesFromAD()
        {
            //open a new search for PCs from AD
            DirectoryEntry root = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    //if the returned item has schema name of Computer
                    if (computer.SchemaClassName == "Computer")
                    {
                        //put it in the list
                        listBox1.Items.Add(computer.Name);
                    }
                }
            }
        }

        private void getInfoMulti(string username, string password)
        {
            IList<string> returnedResults = new List<string>();

            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                    try
                    {
                        string computer = @"""" + listBox1.SelectedItem.ToString() + @"""";

                         OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

                        //see if the machine is up
                        command = "ping " + comp;

                        var isItUp = openCommandPrompt.SendCommand(command);

                        if (isItUp.Contains("Request timed out."))
                        {
                            returnedResults.Add(comp + ": This machine appears to be off.");
                        }
                        else if (isItUp.Contains("Ping request could not find host"))
                        {
                            returnedResults.Add(comp + ": This computer does not exist.");
                        }
                        else
                        {
                            try
                            {
                                if (serialNumberCBMulti.Checked)
                                {
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    //find serial number command
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " csproduct get vendor, name, identifyingnumber /format:list";
                                    ///format:htable - Displays a pretty preformatted table for us.
                                    //put it in the browser1 control in the divSerial section
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                }

                                if (procCBMulti.Checked)
                                {
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " cpu get Name /format:list";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                }

                                if (ramCBMulti.Checked)
                                {
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " memorychip get capacity /format:value";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                }

                                if (hddCBMulti.Checked)
                                {
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " diskdrive get caption /format:value";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                }

                                if (osCBMulti.Checked)
                                {
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " os get SerialNumber, OSArchitecture, Caption /format:value";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                    osInfo = openCommandPrompt.SendCommand(command);
                                }
                                if (currUserCBMulti.Checked)
                                {
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " computersystem get UserName, Name /format:value";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                }
                                if (softwareCBMulti.Checked)
                                {
                                    string filter = "\"Name like '%Eset%'\"";
                                    string filter2 = "\"Name like '%Adobe%'\"";
                                    string filter3 = "\"Name like '%Office%'\"";
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " wmic product where" + filter + "get Name, Version";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " wmic product where" + filter2 + "get Name, Version";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                    //OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " wmic product where" + filter3 + "get Name, Version";
                                    returnedResults.Insert(i, openCommandPrompt.SendCommand(command));
                                }
                                
                            }
                            catch (Exception ex)
                            {
                                //countTimer.Stop();
                                //returnResultsLbl.Text = "";
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                //add items to the grid view
                dataGridView1.DataSource = returnedResults.Select(x => new { Value = x }).ToList();
            }
        }

        #endregion


    }
}
