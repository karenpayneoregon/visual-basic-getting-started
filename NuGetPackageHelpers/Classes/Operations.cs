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
            if (solutionName.Length == 1)
            {
                Console.WriteLine(Path.GetFileName(solutionName[0]));
            }
            Solution = new Solution() {Folder = solutionFolder, SolutionName = solutionName.Length == 1 ? Path.GetFileName(solutionName[0]) : ""};

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
                        string identifier = packageNode.Attribute("id").Value;
                        string version = packageNode.Attribute("version").Value;

                        DisplayInformationHandler?.Invoke($"    {identifier}, {version}");
                        package.PackageItems.Add(new PackageItem() {Name = identifier, Version = version});

                    }


                    Solution.Packages.Add(package);

                    DisplayInformationHandler?.Invoke("");
                }
             
            }
        }
    }
}
