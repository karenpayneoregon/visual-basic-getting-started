using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackageHelpers.Classes
{
    public class Package
    {
        public string ProjectName { get; set; }
        public List<PackageItem> PackageItems { get; set; }
        public int ItemCount => PackageItems.Count;
        public override string ToString() => ProjectName;

        public Package()
        {
            PackageItems = new List<PackageItem>();
        }
    }
}
