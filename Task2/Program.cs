using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Professional/Desktop/ИТМО_учеба/Lab8/Lab8.txt";// Создаем текстовый файл в каталоге текущей лабораторной работы
            using (File.Create(path));
            Random random = new Random();
            StreamWriter sw = new StreamWriter(path, true);
            {
                for (int i = 0; i < 10; i++)//Записываем построчно в текстовый файл 10 случайных чисел от -50 до +50
                {
                    int a = random.Next(-50, 50);
                    sw.WriteLine("{0}",a);
                }
            }
            sw.Close();
            int sum =0;
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)//Считываем построчно числа из файладо тех пор пока не "упремся" в пустую строку и накапливаем сумму
                {
                    Console.WriteLine(line);
                    sum += Convert.ToInt32(line);
                }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
