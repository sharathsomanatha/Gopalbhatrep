using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath =
                "D:\\projects\\Support\\2020R3\\server-carenotes\\src\\CareNotesWebApp\\\\TempData\\UploadedFiles\\HSCOrgRefData_Full_CC130520.xml";
            XDocument document = XDocument.Load(filePath);
            var relQuery = from element in document.Descendants("Organisation")
                where element.Element("Roles") != null && element.Element("Roles").Elements("Role").Any(x => x.Attribute("id").Value == "RO98" && x.Attribute("primaryRole").Value == "true" && x.Element("Status").Attribute("value").Value == "Active")
                select element;

            Console.WriteLine(relQuery.Count());
            string relationship = string.Empty;
            foreach (var rel in relQuery)
            {
               var re2Value = rel.Element("Rels") != null
                    ? rel.Element("Rels").Elements("Rel").FirstOrDefault(x =>
                        x.HasAttributes && x.Attribute("id").Value == "RE2" &&
                        x.Element("Status").Attribute("value").Value == "Active" &&
                        x.Element("Target").Element("OrgId").Attribute("extension") != null)
                    : null;
                relationship = re2Value.Value;

            }
            
        }
    }
}
