namespace ServiceTagPuller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPassStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnResultsLbl = new System.Windows.Forms.Label();
            this.MainTabPage = new System.Windows.Forms.TabControl();
            this.onePCTab = new System.Windows.Forms.TabPage();
            this.macCB = new System.Windows.Forms.CheckBox();
            this.officeCB = new System.Windows.Forms.CheckBox();
            this.antivirusCB = new System.Windows.Forms.CheckBox();
            this.adobeCB = new System.Windows.Forms.CheckBox();
            this.hddCB = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currUserCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.osInfoCB = new System.Windows.Forms.CheckBox();
            this.procCB = new System.Windows.Forms.CheckBox();
            this.ramCB = new System.Windows.Forms.CheckBox();
            this.serialNumCB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminPassTB = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminUserNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compNameSearchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindItbtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.multiPCTab = new System.Windows.Forms.TabPage();
            this.copySelectedBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.softwareCBMulti = new System.Windows.Forms.CheckBox();
            this.hddCBMulti = new System.Windows.Forms.CheckBox();
            this.currUserCBMulti = new System.Windows.Forms.CheckBox();
            this.osCBMulti = new System.Windows.Forms.CheckBox();
            this.procCBMulti = new System.Windows.Forms.CheckBox();
            this.ramCBMulti = new System.Windows.Forms.CheckBox();
            this.serialNumberCBMulti = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getDetailsBtn = new System.Windows.Forms.Button();
            this.findMachineBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.userTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.exportADGroupBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.userSearchText = new System.Windows.Forms.TextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.onePCTab.SuspendLayout();
            this.multiPCTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.userTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCredentialsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCredentialsToolStripMenuItem
            // 
            this.saveCredentialsToolStripMenuItem.Name = "saveCredentialsToolStripMenuItem";
            this.saveCredentialsToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.saveCredentialsToolStripMenuItem.Text = "Save Credentials";
            this.saveCredentialsToolStripMenuItem.Click += new System.EventHandler(this.saveCredentialsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPassStoreToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // userPassStoreToolStripMenuItem
            // 
            this.userPassStoreToolStripMenuItem.Name = "userPassStoreToolStripMenuItem";
            this.userPassStoreToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.userPassStoreToolStripMenuItem.Text = "User/Pass Store";
            this.userPassStoreToolStripMenuItem.Click += new System.EventHandler(this.userPassStoreToolStripMenuItem_Click);
            // 
            // returnResultsLbl
            // 
            this.returnResultsLbl.AutoSize = true;
            this.returnResultsLbl.BackColor = System.Drawing.Color.White;
            this.returnResultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnResultsLbl.Location = new System.Drawing.Point(484, 733);
            this.returnResultsLbl.Name = "returnResultsLbl";
            this.returnResultsLbl.Size = new System.Drawing.Size(0, 24);
            this.returnResultsLbl.TabIndex = 23;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.onePCTab);
            this.MainTabPage.Controls.Add(this.multiPCTab);
            this.MainTabPage.Controls.Add(this.userTab);
            this.MainTabPage.Location = new System.Drawing.Point(12, 38);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.SelectedIndex = 0;
            this.MainTabPage.Size = new System.Drawing.Size(1134, 691);
            this.MainTabPage.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTabPage.TabIndex = 26;
            // 
            // onePCTab
            // 
            this.onePCTab.Controls.Add(this.macCB);
            this.onePCTab.Controls.Add(this.officeCB);
            this.onePCTab.Controls.Add(this.antivirusCB);
            this.onePCTab.Controls.Add(this.adobeCB);
            this.onePCTab.Controls.Add(this.hddCB);
            this.onePCTab.Controls.Add(this.label7);
            this.onePCTab.Controls.Add(this.currUserCB);
            this.onePCTab.Controls.Add(this.label5);
            this.onePCTab.Controls.Add(this.osInfoCB);
            this.onePCTab.Controls.Add(this.procCB);
            this.onePCTab.Controls.Add(this.ramCB);
            this.onePCTab.Controls.Add(this.serialNumCB);
            this.onePCTab.Controls.Add(this.label4);
            this.onePCTab.Controls.Add(this.adminPassTB);
            this.onePCTab.Controls.Add(this.label3);
            this.onePCTab.Controls.Add(this.adminUserNameTB);
            this.onePCTab.Controls.Add(this.label2);
            this.onePCTab.Controls.Add(this.compNameSearchTB);
            this.onePCTab.Controls.Add(this.label1);
            this.onePCTab.Controls.Add(this.FindItbtn);
            this.onePCTab.Controls.Add(this.webBrowser1);
            this.onePCTab.Location = new System.Drawing.Point(4, 27);
            this.onePCTab.Name = "onePCTab";
            this.onePCTab.Padding = new System.Windows.Forms.Padding(3);
            this.onePCTab.Size = new System.Drawing.Size(1126, 660);
            this.onePCTab.TabIndex = 0;
            this.onePCTab.Text = "Single PC";
            this.onePCTab.UseVisualStyleBackColor = true;
            // 
            // macCB
            // 
            this.macCB.AutoSize = true;
            this.macCB.Checked = true;
            this.macCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.macCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macCB.Location = new System.Drawing.Point(297, 226);
            this.macCB.Name = "macCB";
            this.macCB.Size = new System.Drawing.Size(74, 28);
            this.macCB.TabIndex = 60;
            this.macCB.Text = "MAC";
            this.macCB.UseVisualStyleBackColor = true;
            // 
            // officeCB
            // 
            this.officeCB.AutoSize = true;
            this.officeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeCB.Location = new System.Drawing.Point(184, 293);
            this.officeCB.Name = "officeCB";
            this.officeCB.Size = new System.Drawing.Size(80, 28);
            this.officeCB.TabIndex = 59;
            this.officeCB.Text = "Office";
            this.officeCB.UseVisualStyleBackColor = true;
            // 
            // antivirusCB
            // 
            this.antivirusCB.AutoSize = true;
            this.antivirusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antivirusCB.Location = new System.Drawing.Point(91, 293);
            this.antivirusCB.Name = "antivirusCB";
            this.antivirusCB.Size = new System.Drawing.Size(103, 28);
            this.antivirusCB.TabIndex = 58;
            this.antivirusCB.Text = "Antivirus";
            this.antivirusCB.UseVisualStyleBackColor = true;
            // 
            // adobeCB
            // 
            this.adobeCB.AutoSize = true;
            this.adobeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adobeCB.Location = new System.Drawing.Point(14, 293);
            this.adobeCB.Name = "adobeCB";
            this.adobeCB.Size = new System.Drawing.Size(89, 28);
            this.adobeCB.TabIndex = 57;
            this.adobeCB.Text = "Adobe";
            this.adobeCB.UseVisualStyleBackColor = true;
            // 
            // hddCB
            // 
            this.hddCB.AutoSize = true;
            this.hddCB.Checked = true;
            this.hddCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hddCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddCB.Location = new System.Drawing.Point(167, 260);
            this.hddCB.Name = "hddCB";
            this.hddCB.Size = new System.Drawing.Size(72, 28);
            this.hddCB.TabIndex = 41;
            this.hddCB.Text = "HDD";
            this.hddCB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 36);
            this.label7.TabIndex = 40;
            this.label7.Text = "Single Machine Details";
            // 
            // currUserCB
            // 
            this.currUserCB.AutoSize = true;
            this.currUserCB.Checked = true;
            this.currUserCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currUserCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currUserCB.Location = new System.Drawing.Point(167, 227);
            this.currUserCB.Name = "currUserCB";
            this.currUserCB.Size = new System.Drawing.Size(138, 28);
            this.currUserCB.TabIndex = 39;
            this.currUserCB.Text = "Current User";
            this.currUserCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(494, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Returned results can take up to 30 seconds to come back.";
            // 
            // osInfoCB
            // 
            this.osInfoCB.AutoSize = true;
            this.osInfoCB.Checked = true;
            this.osInfoCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.osInfoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osInfoCB.Location = new System.Drawing.Point(241, 260);
            this.osInfoCB.Name = "osInfoCB";
            this.osInfoCB.Size = new System.Drawing.Size(94, 28);
            this.osInfoCB.TabIndex = 37;
            this.osInfoCB.Text = "OS Info";
            this.osInfoCB.UseVisualStyleBackColor = true;
            // 
            // procCB
            // 
            this.procCB.AutoSize = true;
            this.procCB.Checked = true;
            this.procCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.procCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procCB.Location = new System.Drawing.Point(91, 260);
            this.procCB.Name = "procCB";
            this.procCB.Size = new System.Drawing.Size(71, 28);
            this.procCB.TabIndex = 36;
            this.procCB.Text = "Proc";
            this.procCB.UseVisualStyleBackColor = true;
            // 
            // ramCB
            // 
            this.ramCB.AutoSize = true;
            this.ramCB.Checked = true;
            this.ramCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ramCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramCB.Location = new System.Drawing.Point(14, 260);
            this.ramCB.Name = "ramCB";
            this.ramCB.Size = new System.Drawing.Size(74, 28);
            this.ramCB.TabIndex = 35;
            this.ramCB.Text = "RAM";
            this.ramCB.UseVisualStyleBackColor = true;
            // 
            // serialNumCB
            // 
            this.serialNumCB.AutoSize = true;
            this.serialNumCB.Checked = true;
            this.serialNumCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serialNumCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumCB.Location = new System.Drawing.Point(14, 227);
            this.serialNumCB.Name = "serialNumCB";
            this.serialNumCB.Size = new System.Drawing.Size(153, 28);
            this.serialNumCB.TabIndex = 34;
            this.serialNumCB.Text = "Serial Number";
            this.serialNumCB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(567, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Enter the IP or Computer Name of the machine you are looking for.";
            // 
            // adminPassTB
            // 
            this.adminPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassTB.Location = new System.Drawing.Point(10, 166);
            this.adminPassTB.Name = "adminPassTB";
            this.adminPassTB.PasswordChar = '*';
            this.adminPassTB.Size = new System.Drawing.Size(200, 29);
            this.adminPassTB.TabIndex = 28;
            this.adminPassTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(484, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Enter your admin password for the above account name.";
            // 
            // adminUserNameTB
            // 
            this.adminUserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameTB.Location = new System.Drawing.Point(10, 111);
            this.adminUserNameTB.Name = "adminUserNameTB";
            this.adminUserNameTB.Size = new System.Drawing.Size(200, 29);
            this.adminUserNameTB.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Enter your admin username for access to the remote machine.";
            // 
            // compNameSearchTB
            // 
            this.compNameSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compNameSearchTB.Location = new System.Drawing.Point(10, 354);
            this.compNameSearchTB.MaxLength = 30;
            this.compNameSearchTB.Name = "compNameSearchTB";
            this.compNameSearchTB.Size = new System.Drawing.Size(200, 29);
            this.compNameSearchTB.TabIndex = 30;
            this.compNameSearchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compNameSearchTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "What would you like to return?";
            // 
            // FindItbtn
            // 
            this.FindItbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindItbtn.Location = new System.Drawing.Point(218, 354);
            this.FindItbtn.Name = "FindItbtn";
            this.FindItbtn.Size = new System.Drawing.Size(87, 28);
            this.FindItbtn.TabIndex = 26;
            this.FindItbtn.Text = "Find It";
            this.FindItbtn.UseVisualStyleBackColor = true;
            this.FindItbtn.Click += new System.EventHandler(this.FindItbtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(458, 8);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(8);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(667, 659);
            this.webBrowser1.TabIndex = 11;
            // 
            // multiPCTab
            // 
            this.multiPCTab.Controls.Add(this.copySelectedBtn);
            this.multiPCTab.Controls.Add(this.errorLbl);
            this.multiPCTab.Controls.Add(this.label10);
            this.multiPCTab.Controls.Add(this.exportBtn);
            this.multiPCTab.Controls.Add(this.softwareCBMulti);
            this.multiPCTab.Controls.Add(this.hddCBMulti);
            this.multiPCTab.Controls.Add(this.currUserCBMulti);
            this.multiPCTab.Controls.Add(this.osCBMulti);
            this.multiPCTab.Controls.Add(this.procCBMulti);
            this.multiPCTab.Controls.Add(this.ramCBMulti);
            this.multiPCTab.Controls.Add(this.serialNumberCBMulti);
            this.multiPCTab.Controls.Add(this.listBox1);
            this.multiPCTab.Controls.Add(this.selectAllBtn);
            this.multiPCTab.Controls.Add(this.dataGridView1);
            this.multiPCTab.Controls.Add(this.getDetailsBtn);
            this.multiPCTab.Controls.Add(this.findMachineBtn);
            this.multiPCTab.Controls.Add(this.label8);
            this.multiPCTab.Location = new System.Drawing.Point(4, 27);
            this.multiPCTab.Name = "multiPCTab";
            this.multiPCTab.Padding = new System.Windows.Forms.Padding(3);
            this.multiPCTab.Size = new System.Drawing.Size(1126, 660);
            this.multiPCTab.TabIndex = 1;
            this.multiPCTab.Text = "Multiple PCs";
            this.multiPCTab.UseVisualStyleBackColor = true;
            // 
            // copySelectedBtn
            // 
            this.copySelectedBtn.Location = new System.Drawing.Point(122, 91);
            this.copySelectedBtn.Name = "copySelectedBtn";
            this.copySelectedBtn.Size = new System.Drawing.Size(100, 23);
            this.copySelectedBtn.TabIndex = 61;
            this.copySelectedBtn.Text = "Copy";
            this.copySelectedBtn.UseVisualStyleBackColor = true;
            this.copySelectedBtn.Click += new System.EventHandler(this.copySelectedBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(118, 60);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 18);
            this.errorLbl.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 36);
            this.label10.TabIndex = 59;
            this.label10.Text = "Multiple Machine Details";
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(229, 595);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(100, 33);
            this.exportBtn.TabIndex = 57;
            this.exportBtn.Text = "Export CSV";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // softwareCBMulti
            // 
            this.softwareCBMulti.AutoSize = true;
            this.softwareCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softwareCBMulti.Location = new System.Drawing.Point(228, 288);
            this.softwareCBMulti.Name = "softwareCBMulti";
            this.softwareCBMulti.Size = new System.Drawing.Size(104, 28);
            this.softwareCBMulti.TabIndex = 56;
            this.softwareCBMulti.Text = "Software";
            this.softwareCBMulti.UseVisualStyleBackColor = true;
            // 
            // hddCBMulti
            // 
            this.hddCBMulti.AutoSize = true;
            this.hddCBMulti.Checked = true;
            this.hddCBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hddCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddCBMulti.Location = new System.Drawing.Point(228, 232);
            this.hddCBMulti.Name = "hddCBMulti";
            this.hddCBMulti.Size = new System.Drawing.Size(72, 28);
            this.hddCBMulti.TabIndex = 54;
            this.hddCBMulti.Text = "HDD";
            this.hddCBMulti.UseVisualStyleBackColor = true;
            // 
            // currUserCBMulti
            // 
            this.currUserCBMulti.AutoSize = true;
            this.currUserCBMulti.Checked = true;
            this.currUserCBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currUserCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currUserCBMulti.Location = new System.Drawing.Point(228, 120);
            this.currUserCBMulti.Name = "currUserCBMulti";
            this.currUserCBMulti.Size = new System.Drawing.Size(138, 28);
            this.currUserCBMulti.TabIndex = 53;
            this.currUserCBMulti.Text = "Current User";
            this.currUserCBMulti.UseVisualStyleBackColor = true;
            // 
            // osCBMulti
            // 
            this.osCBMulti.AutoSize = true;
            this.osCBMulti.Checked = true;
            this.osCBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.osCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osCBMulti.Location = new System.Drawing.Point(228, 260);
            this.osCBMulti.Name = "osCBMulti";
            this.osCBMulti.Size = new System.Drawing.Size(94, 28);
            this.osCBMulti.TabIndex = 52;
            this.osCBMulti.Text = "OS Info";
            this.osCBMulti.UseVisualStyleBackColor = true;
            // 
            // procCBMulti
            // 
            this.procCBMulti.AutoSize = true;
            this.procCBMulti.Checked = true;
            this.procCBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.procCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procCBMulti.Location = new System.Drawing.Point(229, 204);
            this.procCBMulti.Name = "procCBMulti";
            this.procCBMulti.Size = new System.Drawing.Size(71, 28);
            this.procCBMulti.TabIndex = 51;
            this.procCBMulti.Text = "Proc";
            this.procCBMulti.UseVisualStyleBackColor = true;
            // 
            // ramCBMulti
            // 
            this.ramCBMulti.AutoSize = true;
            this.ramCBMulti.Checked = true;
            this.ramCBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ramCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramCBMulti.Location = new System.Drawing.Point(228, 176);
            this.ramCBMulti.Name = "ramCBMulti";
            this.ramCBMulti.Size = new System.Drawing.Size(74, 28);
            this.ramCBMulti.TabIndex = 50;
            this.ramCBMulti.Text = "RAM";
            this.ramCBMulti.UseVisualStyleBackColor = true;
            // 
            // serialNumberCBMulti
            // 
            this.serialNumberCBMulti.AutoSize = true;
            this.serialNumberCBMulti.Checked = true;
            this.serialNumberCBMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serialNumberCBMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumberCBMulti.Location = new System.Drawing.Point(228, 148);
            this.serialNumberCBMulti.Name = "serialNumberCBMulti";
            this.serialNumberCBMulti.Size = new System.Drawing.Size(153, 28);
            this.serialNumberCBMulti.TabIndex = 49;
            this.serialNumberCBMulti.Text = "Serial Number";
            this.serialNumberCBMulti.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(11, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(211, 508);
            this.listBox1.TabIndex = 48;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(11, 91);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(100, 23);
            this.selectAllBtn.TabIndex = 47;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 656);
            this.dataGridView1.TabIndex = 46;
            // 
            // getDetailsBtn
            // 
            this.getDetailsBtn.Location = new System.Drawing.Point(228, 322);
            this.getDetailsBtn.Name = "getDetailsBtn";
            this.getDetailsBtn.Size = new System.Drawing.Size(100, 33);
            this.getDetailsBtn.TabIndex = 45;
            this.getDetailsBtn.Text = "Get Details";
            this.getDetailsBtn.UseVisualStyleBackColor = true;
            this.getDetailsBtn.Click += new System.EventHandler(this.getDetailsBtn_Click);
            // 
            // findMachineBtn
            // 
            this.findMachineBtn.Location = new System.Drawing.Point(11, 52);
            this.findMachineBtn.Name = "findMachineBtn";
            this.findMachineBtn.Size = new System.Drawing.Size(100, 33);
            this.findMachineBtn.TabIndex = 42;
            this.findMachineBtn.Text = "Find Machines";
            this.findMachineBtn.UseVisualStyleBackColor = true;
            this.findMachineBtn.Click += new System.EventHandler(this.findMachineBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 36);
            this.label8.TabIndex = 41;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.label9);
            this.userTab.Controls.Add(this.exportADGroupBtn);
            this.userTab.Controls.Add(this.label6);
            this.userTab.Controls.Add(this.userListBox);
            this.userTab.Controls.Add(this.userSearchText);
            this.userTab.Controls.Add(this.findBtn);
            this.userTab.Location = new System.Drawing.Point(4, 27);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(1126, 660);
            this.userTab.TabIndex = 2;
            this.userTab.Text = "User";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Enter Domain Username";
            // 
            // exportADGroupBtn
            // 
            this.exportADGroupBtn.Location = new System.Drawing.Point(243, 300);
            this.exportADGroupBtn.Name = "exportADGroupBtn";
            this.exportADGroupBtn.Size = new System.Drawing.Size(75, 24);
            this.exportADGroupBtn.TabIndex = 5;
            this.exportADGroupBtn.Text = "Export";
            this.exportADGroupBtn.UseVisualStyleBackColor = true;
            this.exportADGroupBtn.Click += new System.EventHandler(this.exportADGroupBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "AD Groups";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 18;
            this.userListBox.Location = new System.Drawing.Point(22, 86);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(215, 238);
            this.userListBox.TabIndex = 3;
            // 
            // userSearchText
            // 
            this.userSearchText.Location = new System.Drawing.Point(22, 56);
            this.userSearchText.Name = "userSearchText";
            this.userSearchText.Size = new System.Drawing.Size(215, 24);
            this.userSearchText.TabIndex = 2;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(243, 56);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 24);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.BackColor = System.Drawing.Color.White;
            this.aboutLbl.Location = new System.Drawing.Point(1104, 4);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(51, 18);
            this.aboutLbl.TabIndex = 27;
            this.aboutLbl.Text = "v.2.3.1";
            this.aboutLbl.Click += new System.EventHandler(this.aboutLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1158, 741);
            this.Controls.Add(this.aboutLbl);
            this.Controls.Add(this.MainTabPage);
            this.Controls.Add(this.returnResultsLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Get PC Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainTabPage.ResumeLayout(false);
            this.onePCTab.ResumeLayout(false);
            this.onePCTab.PerformLayout();
            this.multiPCTab.ResumeLayout(false);
            this.multiPCTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label returnResultsLbl;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPassStoreToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabPage;
        private System.Windows.Forms.TabPage onePCTab;
        private System.Windows.Forms.CheckBox hddCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox currUserCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox osInfoCB;
        private System.Windows.Forms.CheckBox procCB;
        private System.Windows.Forms.CheckBox ramCB;
        private System.Windows.Forms.CheckBox serialNumCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox adminPassTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminUserNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox compNameSearchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindItbtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckBox adobeCB;
        private System.Windows.Forms.Label aboutLbl;
        private System.Windows.Forms.TabPage multiPCTab;
        private System.Windows.Forms.CheckBox softwareCBMulti;
        private System.Windows.Forms.CheckBox hddCBMulti;
        private System.Windows.Forms.CheckBox currUserCBMulti;
        private System.Windows.Forms.CheckBox osCBMulti;
        private System.Windows.Forms.CheckBox procCBMulti;
        private System.Windows.Forms.CheckBox ramCBMulti;
        private System.Windows.Forms.CheckBox serialNumberCBMulti;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getDetailsBtn;
        private System.Windows.Forms.Button findMachineBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox officeCB;
        private System.Windows.Forms.CheckBox antivirusCB;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox userSearchText;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button exportADGroupBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button copySelectedBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox macCB;
    }
}

