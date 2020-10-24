using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace NuGetPackageHelpers.Classes
{
    /// <summary>
    /// WIP
    /// As this is being coded as time permits there could had been a slightly
    /// better way to handle how information is returned yet all works fine.
    /// </summary>
    public class Operations 
    {
        public delegate void DisplayInformation(string sender);
        public static event DisplayInformation DisplayInformationHandler;

        //public static List<Package> Packages;
        public static Solution Solution;


        /// <summary>
        /// Partly done method to create a git table for readme markdown file
        /// </summary>
        public static void BuilderPackageTable(string solutionFolder, string projectType)
        {
            string[] exclude = {".git",".vs", "packages"};

            var solutionName = Directory.GetFiles(solutionFolder, "*.sln");
            Solution = new Solution()
            {
                Folder = solutionFolder,
                SolutionName = solutionName.Length == 1 ? Path.GetFileName(solutionName[0]) : "???"
            };

            var folders = Directory.GetDirectories(solutionFolder).
                Where(path => !exclude.Contains(path.Split('\\').Last()));

            foreach (var folder in folders)
            {
                var fileName = (Path.Combine(folder, "packages.config"));
                var package = new Package(); // {SolutionFolder = solutionFolder };

                if (File.Exists(fileName))
                {
                    
                    var projectFiles = Directory.GetFiles(folder, projectType);

                    if (projectFiles.Length == 0)
                    {
                        continue;
                    }

                    var projectNameWithoutExtension = Path.GetFileNameWithoutExtension(projectFiles[0]);

                    DisplayInformationHandler?.Invoke(projectNameWithoutExtension);
                    package.ProjectName = projectNameWithoutExtension;

                    var document = XDocument.Load(fileName);

                    foreach (var packageNode in document.XPathSelectElements("/packages/package"))
                    {
                        string packageName = packageNode.Attribute("id").Value;
                        string version = packageNode.Attribute("version").Value;

                        DisplayInformationHandler?.Invoke($"    {packageName}, {version}");
                        package.PackageItems.Add(new PackageItem() {Name = packageName, Version = version});

                    }

                    Solution.Packages.Add(package);

                    DisplayInformationHandler?.Invoke("");
                }
             
            }
        }
    }
}
