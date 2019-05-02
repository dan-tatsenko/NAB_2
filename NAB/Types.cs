using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAB
{
    static class Card
    {
        public static string Generate()
        {
            string card;
            Random i = new Random();

            switch (i.Next(0,4))
            {
                case 0:
                    card = "VI"; 
                    break;
                case 1:
                    card = "MC";
                    break;
                case 2:
                    card = "AM";
                    break;
                case 3:
                    card = "JC";
                    break;
                default: card = "VI"; break;
            }
            card += i.Next(420000, 990000).ToString() + "..." + i.Next(100, 999).ToString(); ;
            return card;
        }
    }
}