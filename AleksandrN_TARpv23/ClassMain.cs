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


            //4

            Dictionary<int, string> maakond = new Dictionary<int, string>();
            maakond.Add(1, "Tartumaa");
















            // Список продуктов и их калорийность (калории на 100 грамм)
            var продукты = new List<string> { "Яблоко", "Банан", "Курица", "Рис", "Овсянка" };
            var калорийность = new List<double> { 52, 89, 239, 130, 68 };

            // Запрос данных у пользователя
            Console.WriteLine("Введите ваш вес (в кг):");
            double вес = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ваш рост (в см):");
            double рост = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ваш возраст (в годах):");
            int возраст = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите ваш пол (м/ж):");
            string пол = Console.ReadLine().ToLower();

            Console.WriteLine("Выберите уровень активности: \n1. Сидячий образ жизни\n2. Низкая активность\n3. Умеренная активность\n4. Высокая активность\n5. Очень высокая активность");
            int активность = Convert.ToInt32(Console.ReadLine());

            // Рассчет SBI по уравнению Харриса-Бенедикта
            double SBI;
            if (пол == "м")
            {
                SBI = 66 + (13.7 * вес) + (5 * рост) - (6.8 * возраст);
            }
            else
            {
                SBI = 655 + (9.6 * вес) + (1.8 * рост) - (4.7 * возраст);
            }

            // Множитель активности
            double коэффициент = активность switch
            {
                1 => 1.2,
                2 => 1.375,
                3 => 1.55,
                4 => 1.725,
                5 => 1.9,
                _ => 1.2 // по умолчанию сидячий образ жизни
            };

            double дневнаяКалорийность = SBI * коэффициент;
            Console.WriteLine($"\nВаше суточное потребление калорий: {дневнаяКалорийность:F2} ккал\n");

            // Рассчет сколько можно съесть каждого продукта в день
            Console.WriteLine("Вы можете съесть следующее количество продуктов:");
            for (int i = 0; i < продукты.Count; i++)
            {
                double количество = дневнаяКалорийность / калорийность[i];
                Console.WriteLine($"{продукты[i]}: {количество:F2} грамм");






          

            }
        }
    }
}
