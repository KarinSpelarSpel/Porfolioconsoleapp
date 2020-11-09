using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.NetworkInformation;
using System.Text;

namespace aktielista
{
    class Aktie
    {

        public string m_namn { get; set; }
        public int m_kurs;
        public int m_antalÄgare { get; set; }
        public bool m_noterad;
        public string m_branch;

        public Aktie(string namn, int kurs, int antalÄgare, bool noterad, string branch)
        {
            m_namn = namn;
            m_kurs = kurs;
            m_antalÄgare = antalÄgare;
            m_noterad = noterad;
            m_branch = branch;
        }
        // en metod som visar om aktien är noterad eller ej
        public bool isNoterad()
        {
            if (m_noterad == true)
            {
                Console.WriteLine("Aktien är noterad");
                return true;
            }
            else
            {
                Console.WriteLine("Aktien är INTE noterad ;/");
                return false;
            }
        }
    }
}
        
     

    
    //    public override string ToString()
    //    {
    //        return $"Aktie {namn} ";
    //    }
    //}

