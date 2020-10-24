using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using NuGetPackageHelpers.Classes;

namespace NuGetPackageHelpers
{
    public partial class Form1 : Form
    {

        public Solution Solution = new Solution();

        public Form1()
        {
            InitializeComponent();

            Operations.DisplayInformationHandler += Operations_DisplayHandler;

            ProjectTypeComboBox.DataSource = ProjectTypes.ProjectTypesList();

            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ActiveControl = ProcessSelectSolutionButton;
        }

        private void Operations_DisplayHandler(string sender)
        {
            listView1.Items.Add(sender);
        }

        private void DisplayDetails()
        {
            SolutionFolderLabel.Text = $"Folder: {Solution.Folder}";
            SolutionLabel.Text = $"Solution: {Solution.SolutionName}";
        }

        /// <summary>
        /// Process the current solution this project resides in by language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessCurrentSolutionButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var projectType = ((ProjectType) ProjectTypeComboBox.SelectedItem).Extension;
            Operations.BuilderPackageTable(GetFoldersToParent.GetSolutionFolderPath(), projectType);

            Solution = Operations.Solution;
            DisplayDetails();

        }
        /// <summary>
        /// Process the selected solution from the folder dialog by language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessSelectSolutionButton_Click(object sender, EventArgs e)
        {
            var dialog = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog
            {
                SelectedPath = @"C:\OED\Dotnetland\",
                ShowNewFolderButton = false,
                Description = @"Select solution folder",
                UseDescriptionForTitle = true
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                var projectType = ((ProjectType)ProjectTypeComboBox.SelectedItem).Extension;
                Operations.BuilderPackageTable(dialog.SelectedPath, projectType);

                Solution = Operations.Solution;
                DisplayDetails();

            }
        }
        private void ExportToMarkupButton_Click(object sender, EventArgs e)
        {

            if (Solution.Count >0)
            {
                Console.WriteLine(Solution.Folder);
                foreach (var package in Solution.Packages)
                {
                    Console.WriteLine(package.ProjectName);
                    foreach (var packageItem in package.PackageItems)
                    {
                        Console.WriteLine($"\t{packageItem.Delimited}");
                    }

                    Console.WriteLine();
                }
                
            }
            else
            {
                MessageBox.Show("None");
            }
        }


    }
}
