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
            int Jumlah = tambah();
            Console.WriteLine(Jumlah);
            Jumlah = tambah(b: 20, a: 5);
            Console.WriteLine(Jumlah);
            Jumlah = tambah(10, 10);
            Console.WriteLine(Jumlah);
            Console.ReadLine();
        }
        static int kali(int a, int b)
        {
            int Jumlah = a * b;
            return Jumlah;
        }
        static int tambah(int a = 5, int b = 10 ) 
        {
            return a + b;
        }

    }
}
