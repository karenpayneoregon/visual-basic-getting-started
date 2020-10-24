using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackageHelpers.Classes
{
    public class ProjectType
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public override string ToString() => Name;

    }
}
