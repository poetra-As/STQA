using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematika
{
    /*
  Kelas Matematika utama
  Berisi semua metode untuk melakukan fungsi matematika dasar
  */
    public class Math
    {
        // Menambahkan dua bilangan bulat dan mengembalikan hasilnya

        public static int Add(int a, int b)
        {
            // Jika ada parameter yang sama dengan nilai maksimal bilangan bulat
            // dan yang lainnya lebih besar dari nol
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Menambahkan dua ganda dan mengembalikan hasilnya
        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Kurangi bilangan bulat dari yang lain dan kembalikan hasilnya

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Kurangi dua kali lipat dari yang lain dan kembalikan hasilnya
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Mengalikan dua bilangan bulat dan mengembalikan hasilnya
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Mengalikan dua ganda dan mengembalikan hasilnya
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divides an integer by another and returns the result
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        //  Membagi ganda dengan yang lain dan mengembalikan hasilnya
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
