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

            try
            {
                var computers = GetComputerList.GetComputers();

                //put it in the list
                foreach (var computer in computers)
                {
                    listBox1.Items.Add(computer);
                }
            }
            catch
            {

            }

        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            ////check all the items
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            }
        }

        private void getDetailsBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 5)
            {
                var dialog = Prompt.ShowDialog("Warning!", "This will take a long time to process are you sure you want to continue?");
            }
            getInfoMulti(Settings.Default.UserName, Settings.Default.Password);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                //string a list of computers from the list box
                List<string> computersToExport = new List<string>();

                foreach (var item in listBox1.SelectedItems)
                {
                    //for each computer selected add it to the list
                    computersToExport.Add(item.ToString());
                }
                
                //string out the results
                string saveResults = FileExporter.CSVExport(Settings.Default.UserName, Settings.Default.Password, computersToExport).ToString();

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = "ExportResults.txt";
                //open the save file prompt
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    if (saveFile.FileName != "")
                    {
                        //SAVE IT!
                        File.WriteAllText(saveFile.FileName, saveResults);
                    }
                }
            }  
        }


        //TODO - break this out in to a proper class file by itself
        private void getInfoMulti(string username, string password)
        {
            string command;
            IList<string> returnedResults = new List<string>();

            if (listBox1.SelectedItems.Count > 0)
            {
                int i = 0;
                //for each computer in the list
                foreach (var pc in listBox1.SelectedItems)
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

        #endregion


        #region MyMethods

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

        public void ShowMyDialogBox()
        {
            //Form2 testDialog = new Form2();

            //// Show testDialog as a modal dialog and determine if DialogResult = OK.
            //if (testDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    // Read the contents of testDialog's TextBox.
            //    this.txtResult.Text = testDialog.TextBox1.Text;
            //}
            //else
            //{
            //    this.txtResult.Text = "Cancelled";
            //}
            //testDialog.Dispose();
        }

        //work in progress.....
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
        //work in progress....
        
        #endregion
    }
}



