using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя?");
            string Isname = Console.ReadLine();
            Console.WriteLine("Привет, " + Isname + ", сегодня " + DateTime.Now);
        }
    }
}
