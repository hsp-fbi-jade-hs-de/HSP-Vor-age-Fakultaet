using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultaet
{
    public class Fakultaet
    {
        public int Fakultaet_n(int n)
        {

            int fakultaet = 1;

            //Code hier!

            return fakultaet;
        }

        static void Main(string[] args)
        {
            Fakultaet prg = new Fakultaet();

            Console.WriteLine("Zu elcher Zahl möchtest du die Fakultaet ausgeben?.");
            Console.Write("Eingabe: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fakultaet = prg.Fakultaet_n(n);
            Console.WriteLine(fakultaet);

            Console.ReadKey();

        }
    }
}
