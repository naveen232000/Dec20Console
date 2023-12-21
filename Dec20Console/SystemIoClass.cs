using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec20Console
{
    internal class SystemIoClass
    {
        public static void StrmReadWrite()
        {
            string paths = "D:\\Practice Exercises\\SimpleliLearn Doc .net\\20dec\\Dec20Console\\file.txt";
            StreamWriter streamWriter = new StreamWriter(paths);
            streamWriter.WriteLine("Welcome to file.txt");
            streamWriter.WriteLine("Write your text here");
               streamWriter.Close();
            StreamReader readFile = new StreamReader(paths);
            string reads = readFile.ReadToEnd();

            Console.WriteLine(reads);
            readFile.Close();


        }
        public static void fileStream()
        {
            string paths = "D:\\Practice Exercises\\SimpleliLearn Doc .net\\20dec\\Dec20Console\\file2.txt";
            FileStream filestr = new FileStream(paths,FileMode.Create,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(filestr);
            streamWriter.WriteLine("Welcome to file.txt");
            streamWriter.WriteLine("Write your text here");
            streamWriter.Close();
            FileStream filestrRd = new FileStream(paths, FileMode.Open, FileAccess.Read);
            StreamReader readFile = new StreamReader(filestrRd);
            string reads = readFile.ReadToEnd();
            Console.WriteLine(reads);
            readFile.Close();
        }
        public static void fileclass() {
            string paths = "D:\\Practice Exercises\\SimpleliLearn Doc .net\\20dec\\Dec20Console\\file2.txt";
            File.Exists(paths);
            string ext = Path.GetExtension(paths).Replace(".", "");
            string root = Path.GetPathRoot(paths);
            string pth = Path.GetTempPath();
            Console.WriteLine(ext);
            Console.WriteLine(pth);
            Console.WriteLine(root);

        }
        
    }
}
