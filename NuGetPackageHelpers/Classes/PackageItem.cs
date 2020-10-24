namespace NuGetPackageHelpers.Classes
{
    public class PackageItem
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Delimited => $"{Name},{Version}";
        public override string ToString() => Name;

    }
}