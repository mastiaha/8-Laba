using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string put = @"C:\BIM моделирование\Модуль 1\Visual Studio\8 Laba";
            if (Directory.Exists(put))
            {
                Console.WriteLine("Папки");
                string [] papki = Directory.GetDirectories(put);
                foreach (string s in papki)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] faili = Directory.GetFiles(put);
                foreach (string s in faili)
                {
                    Console.WriteLine("\t{0}",s);
                }
            }
            Console.ReadKey();
        }
    }
}
