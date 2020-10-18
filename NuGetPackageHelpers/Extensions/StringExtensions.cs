using System.Text.RegularExpressions;

namespace NuGetPackageHelpers.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Replace any strings with more than one space with a single space
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="replaceWith"></param>
        /// <returns></returns>
        public static string RemoveDoubleSpacings(this string sender, string replaceWith = "")   
        {
            var options = RegexOptions.None;
            var regex = new Regex("[ ]{2,}", options);

            sender = regex.Replace(sender, replaceWith);

            return sender;
        }
    }
}
