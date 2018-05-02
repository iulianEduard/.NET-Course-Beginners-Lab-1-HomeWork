using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork homeWork = new HomeWork();

            homeWork.CitesteNumere();
            homeWork.SumaNumerelor();
            homeWork.MediaArtimetica();
            homeWork.MediaGeometrica();
            homeWork.OrdineCrescatoare();
            homeWork.OrdineDescrescatoare();
            homeWork.NumerePareImpare();
            homeWork.NumereReprezintaTriunghiDreptunghic();
            homeWork.NumerePrime();

            Console.ReadKey();
        }
    }
}
