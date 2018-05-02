using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HomeWork
    {
        int x, y, z;

        public void CitesteNumere()
        {
            Console.WriteLine("Introduceti valoarea lui x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti valoarea lui y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti valoarea lui z:");
            z = Convert.ToInt32(Console.ReadLine());
        }

        public void SumaNumerelor()
        {
            Console.WriteLine($"Suma numerelor: {x + y + z}");
        }

        public void MediaArtimetica()
        {
            Console.WriteLine($"Media aritmetica: {(x + y + z) / 3}");
        }

        public void MediaGeometrica()
        {
            int produsulNumerelor = x * y * z;
            double mediaGeometrica = Math.Pow(produsulNumerelor, (1.0) / 3);

            Console.WriteLine($"Media geomtrica: {mediaGeometrica}");
        }

        public void OrdineCrescatoare()
        {
            if(x < y && y < z)
            {
                Console.WriteLine($"Numere {x}, {y}, {z} sunt in ordine crescatoare");
            }
            else
            {
                Console.WriteLine($"Numere {x}, {y}, {z} nu sunt in ordine crescatoare");
            }
        }

        public void OrdineDescrescatoare()
        {
            if (x > y && y > z)
            {
                Console.WriteLine($"Numere {x}, {y}, {z} sunt in ordine descrescatoare");
            }
            else
            {
                Console.WriteLine($"Numere {x}, {y}, {z} nu sunt in ordine descrescatoare");
            }
        }

        public void NumerePareImpare()
        {
            int numarImpar = 0, numarPar = 0;

            if(x % 2 == 0)
            {
                numarPar++;
            }
            else
            {
                numarImpar++;
            }

            if(y % 2 == 0)
            {
                numarPar++;
            }
            else
            {
                numarImpar++;
            }

            if (z % 2 == 0)
            {
                numarPar++;
            }
            else
            {
                numarImpar++;
            }

            Console.WriteLine($"Numbere impare: {numarImpar}");
            Console.WriteLine($"Numbere pare: {numarPar}");
        }

        public void NumereReprezintaTriunghiDreptunghic()
        {
            double catete = Math.Pow(x, 2) + Math.Pow(y, 2);
            double ipotenuza = Math.Pow(z, 2);

            if(catete == ipotenuza)
            {
                Console.WriteLine("Numere reprezinta un triunghi dreptunghic");
            }
            else
            {
                Console.WriteLine("Numere reprezinta un triunghi dreptunghic");
            }
        }

        public void NumerePrime()
        {
            bool xPrim = NumarEstePrim(x);
            bool yPrim = NumarEstePrim(y);
            bool zPrim = NumarEstePrim(z);

            Console.WriteLine($"{x} este {xPrim}");
            Console.WriteLine($"{y} este {yPrim}");
            Console.WriteLine($"{z} este {zPrim}");
        }

        private bool NumarEstePrim(int numar)
        {
            int i = 2;
            bool prime = true;

            while (i <= numar / 2)
            {
                if (numar % i == 0)
                {
                    prime = false;
                }
                i += 1;
            }

            return prime;
        }
    }
}
