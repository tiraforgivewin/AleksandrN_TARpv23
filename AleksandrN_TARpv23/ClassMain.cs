using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleksandrN_TARpv23
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Hello everybody!");
            //string nimetus = "Python";
            //Console.WriteLine("Bye bye, {0}", nimetus);
            //ClassFunc.Tere(nimetus);
            //Console.Write("Sisests esimine arv: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Sisests teine arv: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Sisests märk: ");
            //char value = char.Parse(Console.ReadLine());
            //double vastus = ClassFunc.Matematika(a, b, value);
            //Console.WriteLine(vastus);


            //4
            Console.Write("Sisests hind: ");
            double price = double.Parse(Console.ReadLine());
            double vastus = ClassFunc.StartPrice(price);
            Console.WriteLine("Algne hind on, {0}", vastus);

            //8

        }
    }
}
