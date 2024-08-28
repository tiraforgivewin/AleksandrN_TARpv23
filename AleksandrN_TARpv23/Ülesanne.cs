using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksandrN_TARpv23
{
    public class Ülesanne
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //2
            Console.Write("Sisests esimine arv: ");
            double arv1 = double.Parse(Console.ReadLine());
            Console.Write("Sisests teine arv: ");
            double arv2 = double.Parse(Console.ReadLine());
            Console.Write("Sisests kolmas arv: ");
            double arv3 = double.Parse(Console.ReadLine());
            Console.Write("Sisests neljas arv: ");
            double arv4 = double.Parse(Console.ReadLine());
            Console.Write("Sisests viies arv: ");
            double arv5 = double.Parse(Console.ReadLine());
            double[] numbrid = new double[5] {arv1, arv2, arv3, arv4, arv5};
            for (int i = 0; i < numbrid.Length; i++)
            {
                Console.WriteLine(numbrid[i]);

            }
        }
    }
}
