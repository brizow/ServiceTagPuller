using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Linq;
using ServiceTagPuller.Properties;
using System.Text;

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

            //TODO3 add getConfName to init. This will grab your local 
            //computer's name so you can get specs of it as well.
        }

        #region SinglePCTab

        private void FindItbtn_Click(object sender, EventArgs e)
        {
            //fill variables
            string user = adminUserNameTB.Text;
            string pass = adminPassTB.Text;
            string comp = @"""" + compNameSearchTB.Text + @"""";
            getInfoSingle(user, pass, comp);
        }

        private void compNameSearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow enter to function for searching as well
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
                                string filter = "\"Name like 'Adobe%'\"";
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divAdobe").InnerHtml = openCommandPrompt.SendCommand(command);
                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divAdobe").InnerHtml = "";
                            }

                            if (antivirusCB.Checked)
                            {
                                string filter = "\"Name like 'Symantec%'\"";
                                command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:htable";
                                webBrowser1.Document.GetElementById("divAntiVirus").InnerHtml = openCommandPrompt.SendCommand(command);

                            }
                            else
                            {
                                webBrowser1.Document.GetElementById("divAntiVirus").InnerHtml = "";
                            }

                            if (officeCB.Checked)
                            {
                                string filter = "\"Name like 'Office%'\"";
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
            if (Settings.Default.Domain == "")
            {
                errorLbl.Text = "*Please supply a Domain name in Settings.";
            }
            //remove all the items from the list then readd
            listBox1.Items.Clear();

            try
            {
                var computers = GetADItems.GetComputers(Settings.Default.Domain);

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
                //TODO1 - take the returned results and export out only the rows that are not blank or off
                //CSV export
                var csv = new StringBuilder();

                //string a list of computers from the list box
                //List<string> computersToExport = new List<string>();

                //go through each of the returned results
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    ////check the result for blanks - don't add them
                    if(row.Cells[0].Value != "")
                    {
                        //computersToExport.Add(row.ToString());
                        csv.AppendLine(row.Cells[0].Value.ToString());
                    }  
                }

                try
                {
                    //string out the results
                    string saveResults = csv.ToString();

                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "ExportResults.csv";
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
                catch (Exception ex)
                {
                    errorLbl.Text = ex.Message;
                }
            }
        }


        //TODO2 - break this out in to a proper class file by itself
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
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " computersystem get UserName, Name /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));

                                }
                                if (serialNumberCBMulti.Checked)
                                {
                                    //find serial number command
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " csproduct get vendor, name, identifyingnumber /format:csv";
                                    ///format:htable - Displays a pretty preformatted table for us.
                                    //put it in the browser1 control in the divSerial section
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (procCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " cpu get Name /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (ramCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " memorychip get capacity /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (hddCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " diskdrive get caption /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }

                                if (osCBMulti.Checked)
                                {
                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " os get SerialNumber, OSArchitecture, Caption /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));
                                }
                                if (softwareCBMulti.Checked)
                                {
                                    string filter = "\"Name like 'Symantec%'\"";
                                    string filter2 = "\"Name like 'Adobe%'\"";
                                    string filter3 = "\"Name like 'Office%'\"";

                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));

                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter2 + " get Name, Version /format:csv";
                                    returnedResults.Add(openCommandPrompt.SendCommand(command));

                                    command = "wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter3 + " get Name, Version /format:csv";
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
                //for each item in the list we want to find enviro.newline and take everything after
                //for i - go through the returnresult i++
                //what this does is take each item, split it in an array, take the seperated values
                //return results[i] = returnresults[i].split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)[1]


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

        private void findBtn_Click(object sender, EventArgs e)
        {
            string userSearch = userSearchText.Text;
            userListBox.Items.Clear();

            try
            {
                var users = GetADItems.GetADGroups(Settings.Default.Domain, userSearch);
                //put it in the list
                foreach (var user in users)
                {
                    userListBox.Items.Add(user);
                }
            }
            catch
            {

            }
        }
    }
}



