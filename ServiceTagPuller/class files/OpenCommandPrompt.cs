using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTagPuller
{
    public class OpenCommandPrompt
    {
        public string SendCommand(string command)
        {
            try
            {
                string captcha;
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                        new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                //start the CMD process
                proc.Start();
                //read to the end of the text
                captcha = proc.StandardOutput.ReadToEnd();
                //we are done, close the window.
                proc.Close();
                //return results
                return captcha; 
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }
    }
}
