using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ValorRaio
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, A, pi = 3.14159;


            R = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
            A = pi* R * R;

            Console.WriteLine(" A =" + A.ToString("f4", CultureInfo.InvariantCulture));

            Console.ReadLine();





        }




    }
}
