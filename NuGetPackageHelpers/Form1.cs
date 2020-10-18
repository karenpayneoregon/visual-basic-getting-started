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
        public Form1()
        {
            InitializeComponent();

            Operations.DisplayInformationHandler += Operations_DisplayHandler;
        }

        private void Operations_DisplayHandler(string sender)
        {
            listView1.Items.Add(sender);
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Operations.BuilderPackageTable();
        }
    }
}
