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
            Console.OutputEncoding = Encoding.UTF8;
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
        //Console.Write("Sisests hind: ");
        //double price = double.Parse(Console.ReadLine());
        //double vastus = ClassFunc.StartPrice(price);
        //Console.WriteLine("Algne hind on, {0}", vastus);

        //6
        //try
        //{
        //    Console.Write("Sisests pikkus: ");
        //    double pikkus = double.Parse(Console.ReadLine());
        //    string vastus = ClassFunc.Pikkus(pikkus);
        //    Console.WriteLine(vastus);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.ToString());

        //string[]nimed=new string[5] {"Anna", "Inna", "Olga", "Denis", "Martin"};
        ////1v
        //for (int i = 0; i < nimed.Length; i++)
        //{
        //    Console.WriteLine(nimed[i]);

        //}
        ////2v
        //foreach (string nimi in nimed)
        //{
        //    Console.WriteLine(nimi);

        //}
        ////3v
        //int n = 0;
        //while (n<nimed.Length)
        //{
        //    Console.WriteLine(nimed[n]);
        //    n++;
        //}
        ////4v
        //do
        //{
        //    Console.WriteLine(nimed[n-1]);
        //    n--;
        //}while (n>0); 


        //for (int i = 0; i < 7; i++)
        //{
        //    Random random = new Random();
        //    int paev_nr = random.Next(-6, 31);
        //    string paeva_nimetus = ClassFunc.Paevad(paev_nr);
        //    Console.WriteLine(paeva_nimetus);
        //}













        //var tooted = new List<string> { "Õun", "Banaan", "Kana", "Riis", "Kaerahelbed" };
        //var kalorsus = new List<double> { 52, 89, 239, 130, 68 };

        //Console.WriteLine("Sisestage oma kaal (kg):");
        //double kaal = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Sisestage oma pikkus (cm):");
        //double pikkus = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Sisestage oma vanus (aastates):");
        //int vanus = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Määrake oma sugu (mees/naine):");
        //string sugu = Console.ReadLine().ToLower();
        //if (sugu != "mees" && sugu != "naine")  
        //{
        //    Console.WriteLine("Vale sisend, palun sisestage 'mees' või 'naine'.");
        //    return;  
        //}

        //Console.WriteLine("Valige aktiivsuse tase: \n1. Istuv eluviis\n2. Madal aktiivsus\n3. Mõõdukas aktiivsus\n4. Kõrge aktiivsus\n5. Väga kõrge aktiivsus");
        //int aktiivsus = Convert.ToInt32(Console.ReadLine());

        //double SBI;
        //if (sugu == "mees")
        //{
        //    SBI = 66 + (13.7 * kaal) + (5 * pikkus) - (6.8 * vanus);
        //}
        //else
        //{
        //    SBI = 655 + (9.6 * kaal) + (1.8 * pikkus) - (4.7 * vanus);
        //}


        //double koefitsient = aktiivsus switch
        //{
        //    1 => 1.2,
        //    2 => 1.375,
        //    3 => 1.55,
        //    4 => 1.725,
        //    5 => 1.9,
        //    _ => 1.2 
        //};

        //double paevaneKaloraaž = SBI * koefitsient;
        //Console.WriteLine($"\nTeie päevane kaloraaž: {paevaneKaloraaž:F2} kcal\n");


        //Console.WriteLine("Te võite süüa järgmise koguse tooteid:");
        //for (int i = 0; i < tooted.Count; i++)
        //{
        //    double kogus = paevaneKaloraaž / kalorsus[i];
        //    Console.WriteLine($"{tooted[i]}: {kogus:F2} grammi");
        //}







        

        }

    }

}
