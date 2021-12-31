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
            Random random = new Random();
            sw.WriteLine(random.Next(0, 10));
            sw.Close();
            
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
