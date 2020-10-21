using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace NuGetPackageHelpers.Classes
{
    /// <summary>
    /// WIP
    /// </summary>
    public class Operations 
    {
        public delegate void DisplayInformation(string sender);
        public static event DisplayInformation DisplayInformationHandler;


        /// <summary>
        /// Partly done method to create a git table for readme markdown file
        /// </summary>
        public static void BuilderPackageTable()
        {
            string[] exclude = {".git",".vs", "packages"};

            var solutionFolder = GetFoldersToParent.GetSolutionFolderPath();

            var folders = Directory.GetDirectories(solutionFolder).
                Where(path => !exclude.Contains(path.Split('\\').Last()));

            foreach (var folder in folders)
            {
                var fileName = (Path.Combine(folder, "packages.config"));

                if (File.Exists(fileName))
                {
                    
                    var projectFiles = Directory.GetFiles(folder, "*.vbproj");

                    if (projectFiles.Length == 0)
                    {
                        continue;
                    }

                    var projectNameWithoutExtension = Path.GetFileNameWithoutExtension(projectFiles[0]);

                    DisplayInformationHandler?.Invoke(projectNameWithoutExtension);


                    var document = XDocument.Load(fileName);

                    foreach (var packageNode in document.XPathSelectElements("/packages/package"))
                    {
                        string identifier = packageNode.Attribute("id").Value;
                        string version = packageNode.Attribute("version").Value;

                        DisplayInformationHandler?.Invoke($"    {identifier}, {version}");

                    }

                    DisplayInformationHandler?.Invoke("");
                }
             
            }
        }
    }
}
