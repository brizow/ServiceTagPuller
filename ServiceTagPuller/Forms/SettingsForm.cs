using ServiceTagPuller.Properties;
using System.Windows.Forms;

namespace ServiceTagPuller
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            if (Settings.Default.UserName != "" && Settings.Default.Password != "")
            {
                //push saved settings in to place
                userNameTB.Text = Settings.Default.UserName;
                passwordTB.Text = Settings.Default.Password;
            }
        }

        private void showPasswordBtn_Click(object sender, System.EventArgs e)
        {
            //switch view of password on button push
            if (passwordTB.UseSystemPasswordChar == true)
            {
                passwordTB.UseSystemPasswordChar = false;
                showPasswordBtn.Text = "Hide";
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
                showPasswordBtn.Text = "Show";
            }
        }

        private void saveChangesBtn_Click(object sender, System.EventArgs e)
        {
            //save changes
            Settings.Default.UserName = userNameTB.Text;
            Settings.Default.Password = passwordTB.Text;
            Settings.Default.Domain = domainTB.Text;
            Settings.Default.Save();
            //close the settings form
            this.Close();
        }
    }
}
