using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/Log.txt";
            StreamWriter sw = new StreamWriter(path);
            int[] chisla = new int[10];
            Random random = new Random();
            foreach (int a in chisla)
            {
                sw.WriteLine("{0} ", random.Next(0, 10));
            }
            sw.Close();

            int[] sum = File.ReadAllLines(path).Select(int.Parse).ToArray();
            int sum1 = sum.Sum();

            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine(sum1);
            
            Console.ReadKey();


            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
