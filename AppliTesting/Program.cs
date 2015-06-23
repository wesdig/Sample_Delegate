using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var mylist = new List<string> { "fabrice", "maxime", "alexandre", "fabien", "bernard", "yannick", "samuel" };

            DisplayFilter(mylist, IsFabrice);
            DisplayFilter(mylist, ContainsFab);
            DisplayFilter(mylist, m => m.EndsWith("n"));
            Console.ReadLine();
        }

        static void DisplayFilter(List<string> persons, FilterList filter)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (filter(persons[i]))
                {
                    Console.WriteLine("Résultat : {0} / Index : {1}", persons[i], i);
                }
            }
        }

        public delegate bool FilterList(string list);

        static bool IsFabrice(string person)
        {
            return person == "fabrice";
        }

        static bool ContainsFab(string person)
        {
            return person.ToLower().Contains("fab");
        }
    }
}
