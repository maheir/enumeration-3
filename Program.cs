using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_8__énumération_
{
    class Program
    {
        enum week
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            week lundi = week.Lundi;
            Console.WriteLine(lundi);
            week Mardi = week.Mardi;
            Console.WriteLine(Mardi);
            week Mercredi = week.Mercredi;
            Console.WriteLine(Mercredi);
            week Jeudi = week.Jeudi;
            Console.WriteLine(Jeudi);
            week Vendredi = week.Vendredi;
            Console.WriteLine(Vendredi);
            week Samedi = week.Samedi;
            Console.WriteLine(Samedi);
            week Dimanche = week.Dimanche;
            Console.WriteLine(Dimanche);
            Console.WriteLine("\n" + Enum.GetName(typeof(week), 4));
        }
    }
}
