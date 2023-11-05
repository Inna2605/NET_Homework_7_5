//Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму.
//Створіть клас для кожної істоти Океанаріуму.
//Вони мають містити інформацію про кожну морську істоту.
//Реалізуйте підтримку ітератора для класу «Океанаріум».
//Протестуйте можливість використання foreach для Океанаріуму.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Oceanarium oceanarium = new Oceanarium();
            oceanarium.Add(new Dolphin() { Length = 3, Weight = 70 });
            oceanarium.Add(new Shark() { Length = 4, Weight = 500 });
            oceanarium.Add(new Whale() { Length = 33, Weight = 150000 });

            oceanarium.Print();

            Console.ReadLine();
        }
    }
}
