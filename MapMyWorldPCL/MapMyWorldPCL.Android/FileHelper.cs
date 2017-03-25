using System;
using System.IO;
using Xamarin.Forms;
using MapMyWorldPCL.Android;

[assembly: Dependency(typeof(FileHelper))]
namespace MapMyWorldPCL.Android
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
