using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d, r;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\nNhập vào chiều dài");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhập vào chiều rộng");
            r = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"\n Chu vi:{2 * (d + r)}");
            
            Console.WriteLine($"\n Diện tích:{d * r}");

            Console.WriteLine($"\n Cạnh nhỏ:{Math.Min(d,r)}");
            Console.ReadLine();
        }
    }
}
