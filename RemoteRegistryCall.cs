using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTagPuller
{
    class RemoteRegistryCall
    {
        //List<regdata> listodata = new List<regdata>();

        //public void getInstalledSoftware(string machineName)
        //{
        //    RegistryKey registryKey;

        //    try
        //    {
        //        RegistryKey rKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, machineName);
        //        registryKey = rKey.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall");
        //    }

        //    catch (Exception e)
        //    {
        //        //display message and exit
        //        //MessageBox.Show("Error: " + e.Message);
        //        //return e.Message;
        //    }

        //    //Checksum for total number for software items read from registry
        //    int icountSoftware = 0;
        //    //int machineRunVersion;
        //    DateTime dateWritten = DateTime.Now;
        //    //machineRunVersion = getMaxRunVersion(sMachineName);
        //    //retreives the values of registry items 
        //    //and assigns them a variable name to be referenced by
        //    foreach (string key in registryKey.GetSubKeyNames())
        //    {
        //        icountSoftware++;
        //        RegistryKey activeKey;

        //        try
        //        {
        //            activeKey = registryKey.OpenSubKey(key);
        //        }

        //        catch (IOException e)
        //        {
        //            Console.WriteLine("{0}: {1}",
        //             e.GetType().Name, e.Message);
        //            //return;
        //        }

        //        //string currentUser = tbCurrentUser.Text;
        //        //string machine = tbRequiredMachine.Text;

        //        string keyID = (string)activeKey.GetValue("keyID");

        //        if (keyID == null)

        //        {
        //            keyID = key;
        //        }

        //        string displayName = (string)activeKey.GetValue("DisplayName");

        //        if (displayName == null)

        //        {
        //            continue;
        //        }

        //        string installLocation = (string)activeKey.GetValue("InstallLocation");
        //        if (installLocation == null)

        //        {
        //            installLocation = "";
        //        }

        //        string displayVersion = (string)activeKey.GetValue("DisplayVersion");

        //        if (displayVersion == null)

        //        {
        //            displayVersion = "";
        //        }

        //        //string contact = (string)activeKey.GetValue("Contact");

        //        //if (contact == null)               
        //        //{
        //        //    contact = "";
        //        //}

        //        //string helpTelephone = (string)activeKey.GetValue("HelpTelephone");

        //        //if (helpTelephone == null)
        //        //{
        //        //    helpTelephone = "";
        //        //}

        //        string installDate = (string)activeKey.GetValue("InstallDate");
        //        if (installDate == null)
        //        {
        //            installDate = "";
        //        }

        //        string publisher = (string)activeKey.GetValue("Publisher");

        //        if (publisher == null || publisher.Equals(""))
        //        {
        //            publisher = "Unknown Publisher";
        //        }

        //        //string helpLink = (string)activeKey.GetValue("HelpLink");

        //        //if (helpLink == null)
        //        //{
        //        //    helpLink = "";
        //        //}

        //        listodata.Add(new regdata() { rkeyID = keyID, rdisplayName = displayName, rinstallLocation = installLocation, rdisplayVersion = displayVersion, rinstallDate = installDate, rpublisher = publisher });
        //    }
        //    return listodata;
        //}
    }

    internal class regdata
    {
        public string rkeyID { get; set; }
        public string rdisplayName { get; set; }
        public string rinstallLocation { get; set; }
        public string rdisplayVersion { get; set; }
        public string rinstallDate { get; set; }
        public string rpublisher { get; set; }
    }
}
