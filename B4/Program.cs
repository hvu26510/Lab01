using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a,b,c;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\na:");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nb:");
            b = int.Parse(Console.ReadLine());
            Console.Write("\nc:");
            c = int.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine($"\n Delta:{delta}");

            Console.WriteLine($"\n Căn Delta:{Math.Sqrt(delta)}");

            Console.ReadLine();
        }
    }
}
