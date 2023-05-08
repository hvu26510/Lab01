using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nNhập vào chiều dài của cạnh");
            c = int.Parse(Console.ReadLine());


            Console.WriteLine($"\n Thể tích:{Math.Pow(c,3)}");

            Console.ReadLine();
        }
    }
}
