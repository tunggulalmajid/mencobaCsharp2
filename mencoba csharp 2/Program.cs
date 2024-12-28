using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mencoba_csharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int Jumlah = kali(a, b);
            Console.WriteLine($"hasil kali dari {a} dan {b} adalah {Jumlah}");
            Console.ReadLine();
        }
        static int kali(int a, int b)
        {
            int Jumlah = a * b;
            return Jumlah;
        }

    }
}
