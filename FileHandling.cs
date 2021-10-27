using System.IO;

namespace Datastore
{
    class FileHandling
    {
        private static string BaseFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
        private static string ProgFolder = "\\Datastore";

        public static string WorkingFolder = BaseFolder + ProgFolder;

        public static void SetupWorkingFolder() 
        {
            if (!Directory.Exists(WorkingFolder))
                Directory.CreateDirectory(WorkingFolder);
        }

        public static void WriteFileContents(string FilePath, string Contents)
        {
            try { File.WriteAllText(FilePath, Contents); } catch { }
        }

        public static string ReadFileContents(string FilePath)
        {
            try { return File.ReadAllText(FilePath); } catch { return ""; }
        }
    }
}
