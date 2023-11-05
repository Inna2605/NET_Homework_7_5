//Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму.
//Створіть клас для кожної істоти Океанаріуму.
//Вони мають містити інформацію про кожну морську істоту.
//Реалізуйте підтримку ітератора для класу «Океанаріум».
//Протестуйте можливість використання foreach для Океанаріуму.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_5
{
    public class Oceanarium:IEnumerable<Oceanarium>
    {
        public int Weight {  get; set; }
        public int Length { get; set; }
        public virtual string Species {  get; set; }

        List<Oceanarium> obj = new List<Oceanarium>();
        
        public IEnumerator<Oceanarium> GetEnumerator()
        {
            return obj.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return obj.GetEnumerator();
        }
        public void Add(Oceanarium oc)
        {
            obj.Add(oc);
        }
        public void Print()
        {
            foreach (Oceanarium oc in obj)
            {
                Console.WriteLine(oc.Species);
                Console.WriteLine($"Довжина: {oc.Length}  Вага: {oc.Weight}");
            }
        }
    }
}
