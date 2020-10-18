using System;
using System.Collections.Generic;
using System.IO;

namespace NuGetPackageHelpers.Classes
{
  
    public static class GetFoldersToParent
    {
        /// <summary>
        /// Get current solution folder
        /// </summary>
        /// <returns></returns>
        public static string GetSolutionFolderPath() => UpperFolder(AppDomain.CurrentDomain.BaseDirectory, 4);

        public static string UpperFolder(string folderName, int level)
        {
            var folderList = new List<string>();

            while (!string.IsNullOrEmpty(folderName))
            {
                var currentFolder = System.IO.Directory.GetParent(folderName);

                if (currentFolder == null)
                {
                    break;
                }

                folderName = Directory.GetParent(folderName).FullName;
                folderList.Add(folderName);

            }

            if (folderList.Count > 0 && level > 0)
            {
                if (level - 1 <= folderList.Count - 1)
                {
                    return folderList[level - 1];
                }
                else
                {
                    return folderName;
                }
            }
            else
            {
                return folderName;
            }
        }
    }
}
