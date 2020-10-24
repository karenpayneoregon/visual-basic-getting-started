using System.Collections.Generic;

namespace NuGetPackageHelpers.Classes
{
    public class Solution
    {
        /// <summary>
        /// Location of solution
        /// </summary>
        public string Folder { get; set; }
        public string SolutionName { get; set; }
        public List<Package> Packages { get; set; }
        public int Count => Packages.Count;
        public override string ToString() => SolutionName;

        public Solution()
        {
            Packages = new List<Package>();
        }

    }
}