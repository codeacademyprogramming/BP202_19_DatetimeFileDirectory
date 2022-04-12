using System;
using System.IO;
namespace FileTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Eagha\Desktop\Files\";
            Console.WriteLine("Folder Adi daxil edin : ");
            string folderName = Console.ReadLine();
            string newPath = path +folderName;
            DirectoryInfo dI= new DirectoryInfo(newPath);
            dI.Create();
            
            bool check = true;
            while (check)
            {
                Console.WriteLine("Yeni folder yaransin ? :");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        Console.WriteLine("Yeni folderin adini yazin : ");
                        string answer2 = Console.ReadLine();
                        newPath = path + answer2;
                        DirectoryInfo directoryInfo2 = new DirectoryInfo(newPath);
                        if (!directoryInfo2.Exists)
                        {
                            directoryInfo2.Create();
                        }
                        else
                        {
                            Console.WriteLine("Bu adda folder var");
                        }
                        break;
                    case "n":
                        check = false;
                        break;
                    default:
                        break;
                }
            }
            

        }
    }
}
