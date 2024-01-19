using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fp_Setul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pb1();
            //Pb2();
            //Pb3();
            Pb4();
        }

        private static void Pb4()
        {
            int smin = 0;
            int smax = 0;
            int min;
            int max;
            Console.WriteLine("Introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] V = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1}");
                V[i] = int.Parse(Console.ReadLine());
            }
            min = V[0];
            max = V[0];
            for (int i = 1; i < n; i++)
            {
                if (V[i] < min)
                {
                    min = V[i];
                    smin = 1;
                }
                else if (V[i] == min)
                {
                    smin++;
                }
                if (V[i] > max)
                {
                    max = V[i];
                    smax = 1;
                }
                else if (V[i] == max)
                {
                    smax++;
                }
            }
            Console.WriteLine($"Cea mica valoare este {min} iar ea apare de {smin ori}");
            Console.WriteLine($"Cea mica valoare este {max} iar ea apare de {smax ori}");



        }



        private static void Pb2()
        {
            int ok = 1;
            Console.WriteLine("Introdu lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti valoare k");
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti elementul {i + 1} a vectorului");
                v[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"Elementul k se afla pe pozitia {i + 1}");
                    ok = 1;
                }

            }

            if (ok == 0)
            {
                Console.WriteLine("-1");
            }

        }

        private static void Pb1()
        {
            int s = 0;
            Console.WriteLine("Introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introdu elemntul {i + 1} a vectorului");
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                s = s + v[i];
            }

            Console.WriteLine($"Suma elementelor vectorului este {s}");
        }
    }
}
