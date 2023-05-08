using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF8;

            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Fpoly chào mừng bạn đến với C#");
            Console.ReadLine();
        }
    }
}
