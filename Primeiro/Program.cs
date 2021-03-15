using System;
using System.Globalization;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            /*double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
            A = pi * R * R;

            Console.WriteLine("A = " + A.ToString("F4", CultureInfo.InvariantCulture));*/

            /* int A, B, C, D, dif;

             A = int.Parse(Console.ReadLine());
             B = int.Parse(Console.ReadLine());
             C = int.Parse(Console.ReadLine());
             D = int.Parse(Console.ReadLine());

             dif = A * B - C * D;

             Console.WriteLine("DIFERENÇA = {0}", dif); */

            /*int numberFun = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());
            double valueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hoursWork * valueHours;

            Console.WriteLine("NUMBER = {0}", numberFun);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));*/

            /*string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int peca1 = int.Parse(vet1[1]);
            double value1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int peca2 = int.Parse(vet2[1]);
            double value2 = double.Parse(vet2[2],  CultureInfo.InvariantCulture);

            double result = peca1 * value1 + peca2 * value2;

            Console.WriteLine("VALOR A PAGAR: R$ "  + result.ToString("F2", CultureInfo.InvariantCulture));*/

            /*double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            string[] vect = Console.ReadLine().Split(' ');
            A = double.Parse(vect[0], CultureInfo.InvariantCulture);
            B = double.Parse(vect[1], CultureInfo.InvariantCulture);
            C = double.Parse(vect[2], CultureInfo.InvariantCulture);

            triangulo = A * C /2.0;
            circulo = pi * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));*/
        }
    }
}
