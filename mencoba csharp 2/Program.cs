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
            //int Jumlah = tambah();
            //Console.WriteLine(Jumlah);
            //Jumlah = tambah(b: 20, a: 5);
            //Console.WriteLine(Jumlah);

            
            Console.WriteLine(tambah("a", "b"));
            Console.WriteLine(tambah(2.1, 10.4));
            Console.WriteLine(tambah(2, 10));
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

        /* method overloading, method yang bisa digunakan untuk tipedata yang berbeda */
        static double tambah(double a, double b) 
        { 
            return a + b;
        }
        static string tambah(string a, string b)
        {
            return a + b;
        }
    }
}
