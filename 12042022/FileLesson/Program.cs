using System;
using System.IO;

namespace FileLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Eagha\Desktop\CodeLessons";
            DirectoryInfo dirInfo = new DirectoryInfo(path);


            foreach (var item in dirInfo.GetDirectories())
            {
                Console.WriteLine(item.Name);
                if(item.Name == "BP202")
                {
                    Console.WriteLine("\t inside BP202:");
                    foreach (var bpDir in item.GetDirectories())
                    {
                        Console.WriteLine("\t"+bpDir.Name+" - creation: "+bpDir.CreationTime.ToString("dd.MM.yyy HH:mm")+" - write: "+ bpDir.LastWriteTime.ToString("dd.MM.yyy HH:mm"));
                    }
                }
            }

            string filePath = path + @"\content.txt";
            string[] content =
            {
                "Salam",
                "Sag ol",
                "Hello, World!"
            };


            //CreateFile(filePath, content);

            ReadFile(filePath);
        }

        static void CreateFile(string path,string[] content)
        {
            FileInfo fi = new FileInfo(path);

            if (!fi.Exists)
            {
                var stream = fi.Create();
                stream.Close();
            }

            File.WriteAllLines(path, content);
        }

        static void ReadFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);

            if (!fileInfo.Exists) return ;

            foreach (var line in File.ReadAllLines(path))
            {
                Console.WriteLine(line);
            }

        }
    }
}
