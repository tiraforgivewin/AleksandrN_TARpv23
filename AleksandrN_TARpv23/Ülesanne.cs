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
            //Console.Write("Sisests esimine arv: ");
            //double arv1 = double.Parse(Console.ReadLine());
            //Console.Write("Sisests teine arv: ");
            //double arv2 = double.Parse(Console.ReadLine());
            //Console.Write("Sisests kolmas arv: ");
            //double arv3 = double.Parse(Console.ReadLine());
            //Console.Write("Sisests neljas arv: ");
            //double arv4 = double.Parse(Console.ReadLine());
            //Console.Write("Sisests viies arv: ");
            //double arv5 = double.Parse(Console.ReadLine());
            //double[] numbrid = new double[5] {arv1, arv2, arv3, arv4, arv5};
            //double massivKogus = numbrid.Length;
            //var vastus = ClassFunc.Toimingud_Numbridega(arv1, arv2, arv3, arv4, arv5, massivKogus);
            //Console.WriteLine($"Summa on: {vastus.sum}, Keskmine on: {vastus.kesk}, Korrutis on: {vastus.korr}");




            //3
            var users = new (string Name, int Age)[5];

            // Küsimuste tsükkel
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Sisestage {i + 1}. kasutaja nimi:");
                string name = Console.ReadLine();

                Console.WriteLine($"Sisestage {i + 1}. kasutaja vanus:");
                int age = int.Parse(Console.ReadLine());

                users[i] = (name, age);
            }

            // Summaarse vanuse arvutamine
            int totalAge = users.Sum(user => user.Age);

            // Aritmeetilise keskmise arvutamine
            double averageAge = users.Average(user => user.Age);

            // Vanima inimese leidmine
            var oldestUser = users.OrderByDescending(user => user.Age).First();

            // Noorima inimese leidmine
            var youngestUser = users.OrderBy(user => user.Age).First();

            // Väljasta tulemused
            Console.WriteLine($"\nSummaarne vanus: {totalAge}");
            Console.WriteLine($"Aritmeetiline keskmine vanus: {averageAge:F2}");
            Console.WriteLine($"Vanem kasutaja: {oldestUser.Name}, Vanus: {oldestUser.Age}");
            Console.WriteLine($"Noorem kasutaja: {youngestUser.Name}, Vanus: {youngestUser.Age}");

            //4
            string userInput = "";

            while (userInput.ToLower() != "elevant")
            {
                Console.WriteLine("Osta elevant ära!");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Aitäh, et lõpuks elevandi ostsid!");
        }
    }
}
