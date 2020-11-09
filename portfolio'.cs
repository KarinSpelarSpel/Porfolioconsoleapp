using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace aktielista
{
    class Aktier : Iportölj
    {
        int vinst = 0;
        int insats = 0;
        private List<Aktie> PortfolioList = new List<Aktie>();
        
        // gör till inputs
        public int getVinst()
        {
            return vinst;

        }
        public int getInsats()
        {
            return insats;
        }
        public int totAvkastning()
        {
            return vinst - insats;
        }

        private static void PortfolioList2(List<string> PortfolioList)
        {
            foreach (string item in PortfolioList)
            {

                {
                    return;

                }


                // printa portföljlistan + avkastning
            }

            static void getPortfolio()
            {



            }

            static void newStock(Aktie aktie)
            {
                Console.WriteLine("newStock");
            }


        }
    }
}
