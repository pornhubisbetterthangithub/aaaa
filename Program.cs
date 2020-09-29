using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {




            Console.WriteLine(" ");
            Console.WriteLine("////////////////////////////2.///////////////////////////////");
            //2.
            int[] tomb = new int[20];
            List<int> szam0 = new List<int>();
            int osszeg = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(50, 151);
                Console.Write(tomb[i] + " ");
                osszeg = osszeg + tomb[i];
                if (tomb[i] % 10 == 0)
                {
                    szam0.Add(tomb[i]);
                }
            }

            int atlag = osszeg / 20;
            Console.WriteLine("\n\nÖsszeg: " + osszeg);
            Console.WriteLine("Átlag: " + atlag);
            Console.Write("0-ra végződő számok: ");
            for (int i = 0; i < szam0.Count; i++)
            {

                Console.Write(szam0[i] + " ");
            }


            //6.
            Console.WriteLine(" ");
            Console.WriteLine("\n////////////////////////////6.///////////////////////////////");
            Console.WriteLine("50db random 2 jegyű számok: ");
            int[] t = new int[50];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
                Console.Write(t[i] + " ");
            }

            //5.
            Console.WriteLine(" ");
            Console.WriteLine("\n////////////////////////////5.///////////////////////////////");

            int ker = 13;
            bool van = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 == 0)
                {

                }
                else
                {
                    Console.Write(t[i] + " ");
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == ker)
                {
                    van = true;
                }

            }
            Console.WriteLine($"\nIgaz-e, hogy van 13-as a tömbben?: {van}");

            Console.WriteLine();
     
            Console.WriteLine("\n////////////3.///////////////");

            int[] tomb3 = new int[20];
            int segedem = 9;
            for (int i = 0; i < tomb3.Length; i++)
            {
                int plusszsegedem = rnd.Next(segedem, 100);
                tomb3[i] = plusszsegedem;
                segedem = plusszsegedem;
                Console.Write(tomb3[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("7.");
            //7.
            int[] lottoTomb = new int[5];
            int lo = lottoTomb.Length;
            for (int i = 0; i < lo; i++)
            {
                int huzas = rnd.Next(0, 21);
                for (int j = 0; j < i; j++)
                    if (lottoTomb[j] > lottoTomb[j + 1])
                    {
                        
                        huzas = lottoTomb[j + 1];
                        lottoTomb[j + 1] = lottoTomb[j];
                        lottoTomb[j] = huzas;
                        
                    }
                    Console.Write("{0} ", lottoTomb[i]);


                //Console.Write(" "+huzas);
            }

            //1.
            Console.WriteLine("\n////////////////////////////1.///////////////////////////////");
            string[] nevek = { "Béla", "Fanni", "Kati", "Panni", "Peti" };
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }
            Console.WriteLine("Add meg a magasságúkat");
            int aa = int.Parse(Console.ReadLine());
            int ab = int.Parse(Console.ReadLine());
            int ac = int.Parse(Console.ReadLine());
            int ad = int.Parse(Console.ReadLine());
            int ae = int.Parse(Console.ReadLine());
            int[] magassag = new int[] { aa, ab, ac, ad, ae };
            int atlagMagassag = (aa + ab + ac + ad + ae) / nevek.Length;
            Console.Write("Átlag Magasságuk: " + atlagMagassag +"\n");
            Console.WriteLine("Ki a legmagasabb? honnéttuggyam");
            Console.ReadKey();

            Console.ReadKey();

        }
    }
}
