using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01PrevizDaniel
{
    class Program
    {
        static int[] adat = new int[1000];
        static void Beolvasas()
        {
            StreamReader stat = new StreamReader("adat.txt");
            while (!stat.EndOfStream)
            {
                string[] szovegAdat = stat.ReadLine().Split(' ');


                for (int i = 0; i < adat.Length; i++)
                {
                    adat[i] = int.Parse(szovegAdat[i]) * 3;
                }
            }
            stat.Close();
            for (int i = 0; i < adat.Length; i++)
            {
                Console.WriteLine(adat[i] + ";");
            }
        }

        static int Minimumertek()
        {
            int min = adat[0];
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i]<min)
                {
                    min = adat[i];
                }
            }
            return min;
        }

        static int Egyediek()
        {
            int db = 0;
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i] % 5 == 0 && adat[i] % 4 != 0)
                {
                    db++;
                }
            }
            return db;

            StreamWriter sw = new StreamWriter("Egyediek.txt", true);

            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i] % 5 == 0 && adat[i] % 4 != 0)
                {
                    adat[i].ToString();
                    sw.WriteLine(adat[i]);
                }
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A minimum: {0}", Minimumertek());
            Console.WriteLine("5 osztható de 4 nem oszthatóak száma: {0}", Egyediek());

            Console.ReadKey();
        }
    }
}
