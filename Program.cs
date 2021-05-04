using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less08
{
    class Program
    {
        //8 Урок. Меланченко Александр
        //С помощью рефлексии выведите все свойства структуры DateTime

        static void Main()
        {
            Type t = typeof(DateTime);
            foreach (var prop in t.GetProperties())
                Console.WriteLine(prop.Name);
            Console.ReadKey();
        }
    }
}
