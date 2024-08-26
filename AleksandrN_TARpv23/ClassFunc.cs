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


        //8
        public static 
    }
}
