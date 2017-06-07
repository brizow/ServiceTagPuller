using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTagPuller
{
    public static class GetComputerList
    {
        public static List<string> GetComputers()
        {
            //build list of computers to return
            List<string> computerNames = new List<string>();

            using (DirectoryEntry entry = new DirectoryEntry("LDAP://merit-group.local"))
            {
                using (DirectorySearcher mySearcher = new DirectorySearcher(entry))
                {
                    mySearcher.Filter = ("(objectClass=computer)");

                    // No size limit, reads all objects
                    mySearcher.SizeLimit = 0;

                    // Read data in pages of 250 objects. Make sure this value is below the limit configured in your AD domain (if there is a limit)
                    mySearcher.PageSize = 250;

                    // Let searcher know which properties are going to be used, and only load those
                    mySearcher.PropertiesToLoad.Add("name");

                    foreach (SearchResult resEnt in mySearcher.FindAll())
                    {
                        // Note: Properties can contain multiple values.
                        if (resEnt.Properties["name"].Count > 0)
                        {
                            string computerName = (string)resEnt.Properties["name"][0];
                            computerNames.Add(computerName);
                            
                            //TODO allow for a variable to fill the sort for maybe ASC, DESC
                            //sorrt the listing by name
                            computerNames.Sort();
                        }
                    }
                }
            }
            return computerNames;
        }
    }
}
