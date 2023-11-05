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
    internal class Shark: Oceanarium
    {
        public override string Species { get; set; } = "Aкула";
    }
}
