using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Linq;
using ServiceTagPuller.Properties;

namespace ServiceTagPuller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //push saved settings in to place
            adminUserNameTB.Text = Settings.Default.UserName;
            adminPassTB.Text = Settings.Default.Password;

            //get HTML text
            string curDir = Directory.GetCurrentDirectory();
            string browsercontent = File.ReadAllText(curDir + "/ResultsBody.html");

            //intialize default browser control
            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.Write(browsercontent);
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
            string user = adminUserNameTB.Text;
            string pass = adminPassTB.Text;
            string comp = @"""" + compNameSearchTB.Text + @"""";
            getInfoSingle(user, pass, comp);
        }
        private void compNameSearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string user = adminUserNameTB.Text;
                string pass = adminPassTB.Text;
                string comp = @"""" + compNameSearchTB.Text + @"""";
                getInfoSingle(user, pass, comp);
            }
        }

        private void getInfoSingle(string username, string password, string computer)
        {
            string command;

            if (compNameSearchTB.Text != "")  //you cannot search your own computer with this...
            {
                try
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

                    //see if the machine is up
                    command = "ping " + computer;
                    var isItUp = openCommandPrompt.SendCommand(command);

                    if (isItUp.Contains("Request timed out."))
                    {
                        webBrowser1.Document.GetElementById("divSerial").InnerHtml = "This computer does not appear to be on.";
                        ClearResults();
                    }
                    else if (isItUp.Contains("Ping request could not find host"))
                    {
                        webBrowser1.Document.GetElementById("divSerial").InnerHtml = "This computer name does not exist.";
                        ClearResults();
                    }
                    else
                    {
                        try
                        {
                            if (currUserCB.Checked)
                            {
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " computersystem get UserName, Name /format:htable";
                                webBrowser1.Document.GetElementById("divUser").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divUser").InnerHtml = "";
                            }

                            if (serialNumCB.Checked)
                            {
                                //find serial number command
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " csproduct get vendor, name, identifyingnumber /format:htable";
                                ///format:htable - Displays a pretty preformatted table for us.
                                //put it in the browser1 control in the divSerial section
                                webBrowser1.Document.GetElementById("divSerial").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divSerial").InnerHtml = "";
                            }

                            if (procCB.Checked)
                            {
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " cpu get Name /format:htable";
                                webBrowser1.Document.GetElementById("divCPU").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divCPU").InnerHtml = "";
                            }

                            if (ramCB.Checked)
                            {
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " memorychip get capacity /format:htable";
                                webBrowser1.Document.GetElementById("divRAM").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divRAM").InnerHtml = "";
                            }


                            if (hddCB.Checked)
                            {
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " diskdrive get caption /format:htable";
                                webBrowser1.Document.GetElementById("divHDD").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divHDD").InnerHtml = "";
                            }

                            if (osInfoCB.Checked)
                            {
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " os get SerialNumber, OSArchitecture, Caption /format:htable";
                                webBrowser1.Document.GetElementById("divOS").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divOS").InnerHtml = "";
                            }

                            if (adobeCB.Checked)
                            {
                                string filter = "\"Name like '%Adobe%'\"";
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divAdobe").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divAdobe").InnerHtml = "";
                            }

                            if (esetCB.Checked)
                            {
                                string filter = "\"Name like '%ESET%'\"";
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divAntiVirus").InnerHtml = openCommandPrompt.SendCommand(command);

                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divAntiVirus").InnerHtml = "";
                            }

                            if (officeCB.Checked)
                            {
                                string filter = "\"Name like '%Office%'\"";
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divOffice").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divOffice").InnerHtml = "";
                            }
                        }
                        catch (Exception ex)
                        {
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

        private void userPassStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForms = new SettingsForm();
            settingsForms.Show();
        }

        private void aboutLbl_Click(object sender, EventArgs e)
        {
            VersionForm ab = new VersionForm();
            ab.Show();
        }

        #endregion

        #region MultiPCTab

        private void findMachineBtn_Click(object sender, EventArgs e)
        {
            //remove all the items from the list then readd
            listBox1.Items.Clear();
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
            getInfoMulti(Settings.Default.UserName, Settings.Default.Password);
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
            //IList<string> returnedResults = new List<string>();

            //foreach (var item in listBox1.SelectedItems)
            //{
            //    comp = item.ToString();   /*.TrimEnd('r', 'n', '/');*/
            //    try
            //    {
            //        OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

            //        //see if the machine is up
            //        command = "ping " + comp;
            //        var isItUp = openCommandPrompt.SendCommand(command);

            //        if (isItUp.Contains("Request timed out."))
            //        {
            //            returnedResults.Add(comp + ": This machine appears to be off.");
            //        }
            //        else if (isItUp.Contains("Ping request could not find host"))
            //        {
            //            returnedResults.Add(comp + ": This computer does not exist.");
            //        }
            //        else
            //        {
            //            returnedResults.Add(comp + ": This computer is up.");
            //        }
            //    }
            //    catch
            //    {

            //    }
            //}
            //add items to the grid view
            //dataGridView1.DataSource = returnedResults.Select(x => new { Value = x }).ToList();


            #endregion
        }

        private void getMachinesFromAD()
        {
            //open a new search for PCs from AD
            DirectoryEntry root = new DirectoryEntry("WinNT:");
            try
            {
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
            catch (Exception ex)
            {
                errorLbl.Text = ex.Message;
            }
            
        }

        private void getInfoMulti(string username, string password)
        {
            //if(listBox1.SelectedItems.Count > 5)
            //{
            //    MessageBox.Show("This will take a very long time to get results, are you sure you want to scan " + listBox1.SelectedItems.Count.ToString());
            //}

            string command;
            IList<string> returnedResults = new List<string>();

            if (listBox1.SelectedItems.Count > 0)
            {
                int i = 0;
                //for each computer in the list
                foreach  (var pc in listBox1.SelectedItems)
                    try
                    {
                        if (i > 0)
                        {
                            returnedResults.Add("");
                        }
                        //pc name
                        string computer = @"""" + pc + @"""";

                        OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

                        //see if the machine is up
                        command = "ping " + computer;

                        var isItUp = openCommandPrompt.SendCommand(command);

                        if (isItUp.Contains("Request timed out."))
                        {
                            returnedResults.Add(computer + ": This machine appears to be off.");
                        }
                        else if (isItUp.Contains("Ping request could not find host"))
                        {
                            returnedResults.Add(computer + ": This computer does not exist.");
                        }
                        else
                        {
                            try
                            {
                                if (currUserCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " computersystem get UserName, Name /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }
                                if (serialNumberCBMulti.Checked)
                                {
                                    //find serial number command
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " csproduct get vendor, name, identifyingnumber /format:table";
                                    ///format:htable - Displays a pretty preformatted table for us.
                                    //put it in the browser1 control in the divSerial section
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (procCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " cpu get Name /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (ramCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " memorychip get capacity /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (hddCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " diskdrive get caption /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (osCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " os get SerialNumber, OSArchitecture, Caption /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }
                                if (softwareCBMulti.Checked)
                                {
                                    string filter = "\"Name like '%ESET%'\"";
                                    string filter2 = "\"Name like '%Adobe%'\"";
                                    string filter3 = "\"Name like '%Office%'\"";

                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));

                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter2 + " get Name, Version /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));

                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter3 + " get Name, Version /format:table";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                            }
                            catch (Exception ex)
                            {
                                return;
                            }
                        }
                        //increment our count
                        i++;
                    }
                    catch (Exception ex)
                    {

                    }

                //add items to the grid view
                dataGridView1.DataSource = returnedResults.Select(x => new { Value = x }).ToList();
            }
        }

        private void CSVExport(string username, string password)
        {
            //List<string> returnedResults = new List<string>();

            //List<string> commands = new List<string>();
            //commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computer + " csproduct get vendor, name, identifyingnumber /format:table");
            //commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computer + " cpu get Name /format:table");
            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " memorychip get capacity /format:table";
            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " diskdrive get caption /format:table";
            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " os get SerialNumber, OSArchitecture, Caption /format:table";
            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " computersystem get UserName, Name /format:table";

            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:table";
            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter2 + " get Name, Version /format:table";
            //command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter3 + " get Name, Version /format:table";)

            //if (listBox1.SelectedItems.Count > 0)
            //{
            //    for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            //        try
            //        {
            //            string computer = @"""" + listBox1.SelectedItems[i].ToString() + @"""";

            //            OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();

            //            string filter = "\"Name like '%ESET%'\"";
            //            string filter2 = "\"Name like '%Adobe%'\"";
            //            string filter3 = "\"Name like '%Office%'\"";

                        
            //        }
            //        catch
            //        {

            //        }
            //}
        }

        private void ClearResults()
        {
            //clear the divs all except the SerialDiv for errors
            //webBrowser1.Document.GetElementById("divSerial").InnerHtml = "";
            webBrowser1.Document.GetElementById("divCPU").InnerHtml = "";
            webBrowser1.Document.GetElementById("divRAM").InnerHtml = "";
            webBrowser1.Document.GetElementById("divHDD").InnerHtml = "";
            webBrowser1.Document.GetElementById("divOS").InnerHtml = "";
            webBrowser1.Document.GetElementById("divOS").InnerHtml = "";
            webBrowser1.Document.GetElementById("divUser").InnerHtml = "";
            webBrowser1.Document.GetElementById("divAntiVirus").InnerHtml = "";
            webBrowser1.Document.GetElementById("divAdobe").InnerHtml = "";
            webBrowser1.Document.GetElementById("divOffice").InnerHtml = "";
        }

        #endregion

        
    }
}
