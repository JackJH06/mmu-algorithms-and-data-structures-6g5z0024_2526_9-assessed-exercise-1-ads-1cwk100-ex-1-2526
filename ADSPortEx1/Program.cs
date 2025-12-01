using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSPortEx1
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            EmergencyQueue queue = new EmergencyQueue(10);
            while (true)
            {
                Console.WriteLine("1 insert item \n 2 remove and show item \n 3 count and show item \n 4 find highest severity level \n 5 dequeue k numbers \n");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Input Name")
                        string name = Console.ReadLine();
                    Console.WriteLine("EmergencyType")
                        string type = Console.Readline();
                    Console.WriteLine("SeverityLevel")
                        int level = int.parse(Console.Readline());
                }
                if (input == 2)
                {
                    Console.WriteLine();
                    queue.Dequeue();
                }
                if ((input == 3)
                {
                    for (int i = 0; i < queue.Count; i++)
                    {
                        Console.WriteLine(queue.store[i].ToString());
                    }
                    Console.WriteLine(queue.Count());
                }
            }
        }
    }
}
