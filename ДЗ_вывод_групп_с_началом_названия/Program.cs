using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_вывод_групп_с_началом_названия
{
    internal class Program
    {
        static void Main()
        {
            List<string> groups = new List<string>() { "П-30", "Б-30", "Э-30", "М-30", "П-31", "Л-30", "П-32" };
            string sought = "П-3";
            var targets = groups.Where(groups.Contains(sought,StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("Найденные элементы: ");



            foreach (var group in targets)
            {
                Console.WriteLine(group);
            }








            Console.ReadKey();
        }
    }
}
