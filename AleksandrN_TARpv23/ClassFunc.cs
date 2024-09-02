using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksandrN_TARpv23
{ 
    internal class ClassFunc
    {
        
        public static double Matematika(double arv1, double arv2, char teha)
        {
            if (teha == '+')
            {
                return arv1 + arv2;

            }
            else if (teha == '-')
            {
                return arv1 - arv2;
            }
            else if (teha == '*')
            {
                return arv1 * arv2;
            }
            else if (teha == '/')
            { 
                return arv1 / arv2;
            }
            return 0;
        }


        //4
        public static double StartPrice(double price)
        {
            return price / 0.7;
        
        }


        //6
        public static string  Pikkus(double pikkus)
        {
            string analuus;
            if (pikkus < 1.60)
            {
                analuus = "Lühika kasv";

            }
            else if (pikkus < 1.8)
            {
                analuus = "Keskmine kasvu inimine";
            }
            else
            {
                analuus = "Pikka kasvu inimine";
            
            }
            return analuus;
        }

        //2
        //public static string Pinginaabrid(string nimi1, string nimi2)
        //{


        //}



        // paeva number -> paeva nimietus
        public static string Paevad(int nr)
        {
            string paev;
            switch (nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Ei saa määrata";
                    break;


            }
            return paev;       

        }


        public static (double sum, double kesk, double korr) Toimingud_Numbridega(double arv1, double arv2, double arv3, double arv4, double arv5, double massivKogus)
        {
            double sum;
            sum = arv1 + arv2 + arv3 + arv4 + arv5;           
            double kesk;
            kesk = (arv1 + arv2 + arv3 + arv4 + arv5) / massivKogus;
            double korr;
            korr = arv1 * arv2 * arv3 * arv4 * arv5;
            return (sum, kesk, korr);




            

        }
    }
}
