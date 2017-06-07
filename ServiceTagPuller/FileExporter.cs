using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServiceTagPuller
{
    public class FileExporter
    {
        public static StringBuilder CSVExport(string username, string password, List<string> computers)
        {
            //CSV export
            var csv = new StringBuilder();
            //results
            List<string> returnedResults = new List<string>();
            try
            {
                foreach (var computer in computers)
                {
                    OpenCommandPrompt openCommandPrompt = new OpenCommandPrompt();
                    //list commands
                    List<string> commands = new List<string>();

                    //pc name
                    string computername = @"""" + computer + @"""";

                    //add each command to the list
                    commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computername + " csproduct get vendor, name, identifyingnumber /format:csv");
                    commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computername + " cpu get Name /format:csv");
                    commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computername + " memorychip get capacity /format:csv");
                    commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computername + " diskdrive get caption /format:csv");
                    commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computername + " os get SerialNumber, OSArchitecture, Caption /format:csv");
                    commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computername + " computersystem get UserName, Name /format:csv");
                    
                    //TODO add software entries
                    //commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter + " get Name, Version /format:csv");
                    //commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter2 + " get Name, Version /format:csv");
                    //commands.Add("wmic /user:" + username + " /password:" + password + " /node:" + computer + " product where " + filter3 + " get Name, Version /format:csv");

                    //run through each command and add it to list
                    foreach (var todo in commands)
                    {
                        returnedResults.Add(openCommandPrompt.SendCommand(todo));
                    }

                }
                //take listed data and build a string with it
                foreach (var item in returnedResults)
                {
                    //remove some white space
                    var resultString = Regex.Replace(item, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
                    csv.AppendLine(resultString);
                }
            }
            catch { }

            //return the results
            return csv;
        }
    }
}
