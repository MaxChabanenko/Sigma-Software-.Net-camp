using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace task15
{
    internal class Program
    {   //    Дано послідовність цілих натуральних чисел і послідовність рядків stringList.Отримайте нову
        //    послідовність рядків за таким правилом: для кожного значення n з порядкових номерів виберіть
        //    рядок зі списку послідовності stringList, який починається з цифри та має довжина n.Якщо в 
        //    послідовності stringList є кілька необхідних рядків, поверніть перший; якщо їх немає, тоді
        //    поверніть рядок «Не знайдено» (щоб вирішити ситуацію, пов’язану з відсутністю необхідних рядків,
        //    використовуйте ?? операцію)
        static IEnumerable Query1(int[] numbers, List<string> stringList)
        {
            var q1 = (from t1 in numbers
                      join t2 in stringList.Where(x => Char.IsNumber(x[0]))
                      on t1 equals t2.Length into a
                      from t2 in a.DefaultIfEmpty()
                      select new
                      {
                          t1 = t1,
                          t2 = t2 ?? "Не знайдено"
                      }).GroupBy(a => a.t1).Select(g => g.First());
            return q1;
        }
        static IEnumerable Query2(int[] numbers, List<string> stringList)
        {
            throw new NotImplementedException();
        }
        static IEnumerable Query3(int[] numbers, List<string> stringList)
        {
            throw new NotImplementedException();
        }
        static IEnumerable Query4(int[] numbers, List<string> stringList)
        {
            throw new NotImplementedException();
        }
        static IEnumerable Query5(int[] numbers, List<string> stringList)
        {
            throw new NotImplementedException();
        }
        static void Main()
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 9, 11 };
            List<string> stringList = new List<string> { "2ne", "2", "4four", "5five", "Hello World" };


            var q1 = Query1(numbers, stringList);
            Console.WriteLine("____1____");
            foreach (var keyval in q1)
                Console.WriteLine(keyval);

            var q2 = Query2(numbers, stringList);
            Console.WriteLine("____2____");
            foreach (var keyval in q2)
                Console.WriteLine(keyval);

            var q3 = Query3(numbers, stringList);
            Console.WriteLine("____3____");
            foreach (var keyval in q3)
                Console.WriteLine(keyval);

            var q4 = Query4(numbers, stringList);
            Console.WriteLine("____4____");
            foreach (var keyval in q4)
                Console.WriteLine(keyval);

            var q5 = Query5(numbers, stringList);
            Console.WriteLine("____5____");
            foreach (var keyval in q5)
                Console.WriteLine(keyval);
        }
        


    }
}
