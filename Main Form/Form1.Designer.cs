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
            this.FindItbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.compNameSearchTB = new System.Windows.Forms.TextBox();
            this.adminUserNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminPassTB = new System.Windows.Forms.MaskedTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNumCB = new System.Windows.Forms.CheckBox();
            this.ramCB = new System.Windows.Forms.CheckBox();
            this.procCB = new System.Windows.Forms.CheckBox();
            this.osInfoCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currUserCB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnResultsLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindItbtn
            // 
            this.FindItbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindItbtn.Location = new System.Drawing.Point(230, 364);
            this.FindItbtn.Name = "FindItbtn";
            this.FindItbtn.Size = new System.Drawing.Size(87, 28);
            this.FindItbtn.TabIndex = 0;
            this.FindItbtn.Text = "Find It";
            this.FindItbtn.UseVisualStyleBackColor = true;
            this.FindItbtn.Click += new System.EventHandler(this.FindItbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "What would you like to return?";
            // 
            // compNameSearchTB
            // 
            this.compNameSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compNameSearchTB.Location = new System.Drawing.Point(22, 364);
            this.compNameSearchTB.MaxLength = 30;
            this.compNameSearchTB.Name = "compNameSearchTB";
            this.compNameSearchTB.Size = new System.Drawing.Size(200, 24);
            this.compNameSearchTB.TabIndex = 3;
            // 
            // adminUserNameTB
            // 
            this.adminUserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameTB.Location = new System.Drawing.Point(22, 149);
            this.adminUserNameTB.Name = "adminUserNameTB";
            this.adminUserNameTB.Size = new System.Drawing.Size(200, 24);
            this.adminUserNameTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your admin password for the above account name.";
            // 
            // adminPassTB
            // 
            this.adminPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassTB.Location = new System.Drawing.Point(22, 204);
            this.adminPassTB.Name = "adminPassTB";
            this.adminPassTB.PasswordChar = '*';
            this.adminPassTB.Size = new System.Drawing.Size(200, 24);
            this.adminPassTB.TabIndex = 2;
            this.adminPassTB.UseSystemPasswordChar = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Location = new System.Drawing.Point(478, 34);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(8);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(671, 724);
            this.webBrowser1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter the IP or Computer Name of the machine you are looking for.";
            // 
            // serialNumCB
            // 
            this.serialNumCB.AutoSize = true;
            this.serialNumCB.Checked = true;
            this.serialNumCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.serialNumCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumCB.Location = new System.Drawing.Point(26, 265);
            this.serialNumCB.Name = "serialNumCB";
            this.serialNumCB.Size = new System.Drawing.Size(121, 22);
            this.serialNumCB.TabIndex = 12;
            this.serialNumCB.Text = "Serial Number";
            this.serialNumCB.UseVisualStyleBackColor = true;
            // 
            // ramCB
            // 
            this.ramCB.AutoSize = true;
            this.ramCB.Checked = true;
            this.ramCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ramCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramCB.Location = new System.Drawing.Point(26, 298);
            this.ramCB.Name = "ramCB";
            this.ramCB.Size = new System.Drawing.Size(60, 22);
            this.ramCB.TabIndex = 15;
            this.ramCB.Text = "RAM";
            this.ramCB.UseVisualStyleBackColor = true;
            // 
            // procCB
            // 
            this.procCB.AutoSize = true;
            this.procCB.Checked = true;
            this.procCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.procCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procCB.Location = new System.Drawing.Point(103, 298);
            this.procCB.Name = "procCB";
            this.procCB.Size = new System.Drawing.Size(59, 22);
            this.procCB.TabIndex = 16;
            this.procCB.Text = "Proc";
            this.procCB.UseVisualStyleBackColor = true;
            // 
            // osInfoCB
            // 
            this.osInfoCB.AutoSize = true;
            this.osInfoCB.Checked = true;
            this.osInfoCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.osInfoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osInfoCB.Location = new System.Drawing.Point(179, 298);
            this.osInfoCB.Name = "osInfoCB";
            this.osInfoCB.Size = new System.Drawing.Size(77, 22);
            this.osInfoCB.TabIndex = 17;
            this.osInfoCB.Text = "OS Info";
            this.osInfoCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Returned results can take up to 30 seconds to come back.";
            // 
            // currUserCB
            // 
            this.currUserCB.AutoSize = true;
            this.currUserCB.Checked = true;
            this.currUserCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currUserCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currUserCB.Location = new System.Drawing.Point(179, 265);
            this.currUserCB.Name = "currUserCB";
            this.currUserCB.Size = new System.Drawing.Size(112, 22);
            this.currUserCB.TabIndex = 19;
            this.currUserCB.Text = "Current User";
            this.currUserCB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 744);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Version 1.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCredentialsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveCredentialsToolStripMenuItem
            // 
            this.saveCredentialsToolStripMenuItem.Name = "saveCredentialsToolStripMenuItem";
            this.saveCredentialsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveCredentialsToolStripMenuItem.Text = "Save Credentials";
            this.saveCredentialsToolStripMenuItem.Click += new System.EventHandler(this.saveCredentialsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // returnResultsLbl
            // 
            this.returnResultsLbl.AutoSize = true;
            this.returnResultsLbl.BackColor = System.Drawing.Color.White;
            this.returnResultsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnResultsLbl.Location = new System.Drawing.Point(484, 733);
            this.returnResultsLbl.Name = "returnResultsLbl";
            this.returnResultsLbl.Size = new System.Drawing.Size(0, 18);
            this.returnResultsLbl.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your admin username for access to the remote machine.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "PC Info Puller";
            // 
            // Form1
            // 
            this.AcceptButton = this.FindItbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1158, 741);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.returnResultsLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currUserCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.osInfoCB);
            this.Controls.Add(this.procCB);
            this.Controls.Add(this.ramCB);
            this.Controls.Add(this.serialNumCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.adminPassTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminUserNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compNameSearchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindItbtn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Get PC Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindItbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox compNameSearchTB;
        private System.Windows.Forms.TextBox adminUserNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox adminPassTB;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox serialNumCB;
        private System.Windows.Forms.CheckBox ramCB;
        private System.Windows.Forms.CheckBox procCB;
        private System.Windows.Forms.CheckBox osInfoCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox currUserCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label returnResultsLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}

