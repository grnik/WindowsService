using System.IO;

namespace Logical
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class LogFile : System.IDisposable
    {
        StreamWriter file;

        public string FileName { get; private set; }

        public LogFile()
        {
            CreateFile();
        }

        ~LogFile()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (file != null)
            {
                file.Close();
            }
        }

        private void CreateFile()
        {
            FileName = Path.GetTempFileName();
            file = File.CreateText(FileName);
        }

        public void Write(string text)
        {
            file.WriteLine(text);
        }
    }
}
