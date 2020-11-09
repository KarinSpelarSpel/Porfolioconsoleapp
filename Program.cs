wusing System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace aktielista
{
    class Program
    {


        public static List<Aktie> portföljList = new List<Aktie>();
        static void Main(string[] args)
        {
            string fileContents = File.ReadAllText(@"C:\CodeProjects\Min Portfölj.txt"); //Eller vad din text.txt fil nu än hteter
            Console.WriteLine("DIN PORTFÖLJ \n---------------------------------------------------------------------------------------------");
            Console.WriteLine(fileContents);
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("NU Kan du lägga till nya aktier i din portfölj");

            Console.WriteLine(" Valfri tangent, x för att stänga programmet");
            HållProgrammetigång();
            Console.ReadLine();
            // variabler, arrays.

            // ny aktie
            Aktie aktie1 = new Aktie("Apple inc", 116, 12044274, true, "Tech");
            Aktie aktie2 = new Aktie("Hennes & Mauritz", 156, 2979413, true, "Kläder");

            //Console.WriteLine(aktie1.isNoterad());
            //Console.WriteLine(aktie1.ToString());
        }

        private static void HållProgrammetigång()
        {
            bool loop = true;
            while (loop == true)
            {
                AddStock();

                string input = Console.ReadLine();
                if (input == "x")
                    loop = false;
            }
            PrintPortfölj();
        }
       
            static public void AddStock()
            {
                Console.WriteLine("Skriv in namnet på aktien");
                string namn = Console.ReadLine();
                Console.WriteLine("Skriv in kursen på aktien");
                int kurs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in antalet ägare på aktien");
                int antalÄgare = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Är aktien noterad? True/False");
                bool noterad = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Vilken branch tillhör aktien?");
                string branch = Console.ReadLine();
                Console.WriteLine("Klicka x för att avsluta, annars vilken knapp som helst för att fortsätta");
                
                


                Aktie aktie = new Aktie(namn, kurs, antalÄgare, noterad, branch);
                portföljList.Add(aktie);
            }
        static public void PrintPortfölj()
        {
            var path = @"C:\CodeProjects\Min Portfölj.txt";
            foreach (var item in portföljList)
            {
                Console.WriteLine($"Namn:  { item.m_namn} \n Kurs: {item.m_kurs} \n Antalägare: {item.m_antalÄgare} \n Branch: {item.m_branch} \n");
                File.AppendAllText(path, $"\n Namn:  { item.m_namn} \n Kurs: {item.m_kurs} \n Antalägare: {item.m_antalÄgare} \n Branch: {item.m_branch}\n");
            }
        }
        }
    }
    

    


