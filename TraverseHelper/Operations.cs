using System;
using System.IO;

namespace TraverseHelper
{
    public class Operations
    {

        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;

        public delegate void OnTraverseFolder(string item);
        /// <summary>
        /// Callback for when a folder is being processed
        /// </summary>
        public static event OnTraverseFolder OnTraverseEvent;


        /// <summary>
        /// Example that will run freely and the app will be unresponsive which
        /// is how many developers approach reading folders and only try with a smaller
        /// folder structure but larger structures will freeze the app thus we
        /// need to consider an asynchronous method.
        /// </summary>
        /// <param name="path">Folder to work with</param>
        /// <param name="indentLevel">Indent level for display with Console.WriteLine</param>
        public static void RecursiveFolders(string path, int indentLevel)
        {

            try
            {

                if ((File.GetAttributes(path) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
                {

                    foreach (var folder in Directory.GetDirectories(path))
                    {
                        OnTraverseEvent?.Invoke(folder);
                        Console.WriteLine($"{new string(' ', indentLevel)}{Path.GetFileName(folder)}");
                        RecursiveFolders(folder, indentLevel + 2);
                    }

                }

            }
            catch (UnauthorizedAccessException unauthorized)
            {
                OnExceptionEvent?.Invoke(unauthorized);
            }
        }

    }
}
