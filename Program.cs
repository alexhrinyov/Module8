using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }

        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }
        static Dictionary<string,Folder> Folders = new Dictionary<string,Folder>();
        public static void AddFolder(string FolderName)
        {
            
            Folders.Add(FolderName,new Folder(FolderName));
        }
    }
    public class Folder
    {
        public string Name { get; set; } 
        public List<string> Files { get; set; } = new List<string>();
        public Folder(string FolderName)
        {
            Name = FolderName;
        }
        void AddFile(string name)
        {
            if (!Files.Contains(name))
                Files.Add(name);
        }
    }
}
