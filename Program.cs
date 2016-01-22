using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            Console.WriteLine("Enter existing file path with extension.");
            Console.Write("> ");
            string pathx = Console.ReadLine();
            Console.WriteLine("Enter new file path with extension.");
            Console.Write("> ");
            string pathy = Console.ReadLine();
            try
            {
                byte[] bytes = File.ReadAllBytes(pathx);
                File.WriteAllBytes(pathy, bytes);
                Console.WriteLine("Done!");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine("Something happened...\n" + e.ToString());
                Console.ReadKey();
            }
        }

        static void Welcome()
        {
            Console.WriteLine("SmartCopy");
            Console.WriteLine("Copyright | 2016 by Móricz Gergő/saxophone All rights reserved.");
        }
    }
}
