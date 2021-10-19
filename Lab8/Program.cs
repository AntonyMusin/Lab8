using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirs = Directory.GetDirectories(@"E:\Учеба ВлГУ");
            foreach (var dir in dirs)
            {
                Console.WriteLine("Наименование каталога: {0}",dir);
                Console.WriteLine("Список файлов:");
                string[] secondDirs = Directory.GetFiles(dir);
                for (int i = 0; i < secondDirs.Length; i++)
                {
                    Console.WriteLine(secondDirs[i]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
