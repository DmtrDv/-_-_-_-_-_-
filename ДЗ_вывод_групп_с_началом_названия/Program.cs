using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_вывод_групп_с_началом_названия
{
    internal class Program
    {
        static void Main()
        {

            /// первый способ
            /*
            Console.WriteLine("Введите группы которые ищите:");
            
            string sought = Console.ReadLine(); //вводим искомое
            List<string> groups = new List<string>() { "П-30", "Б-30", "Э-30", "М-30", "П-31", "Л-30", "П-32" };  //создал список групп


            var targets = groups.Where(gr => gr.IndexOf(sought, StringComparison.OrdinalIgnoreCase) >= 0); //вводим переменную targets(цели) и присваиваем ей значени, значение равно: в списке
                                                                   //спомощью метода where, создания новой переменной gr и метода Contains ищем подходящие элементы
            Console.WriteLine("Найденные элементы: ");

            foreach (var group in targets)
            {
                Console.WriteLine(String.Join(",", group));
            }
            */




            ///второй способ
            
            Console.WriteLine("Введите группы которые ищите:");

            string sought = Console.ReadLine(); //вводим искомое
            List<string> groups = new List<string>() { "П-30", "Б-30", "Э-30", "М-30", "П-31", "Л-30", "П-32" };  //создал список групп
            
            Console.WriteLine("Найденные элементы: ");

            foreach (var group in groups)
            {
                if (group.IndexOf(sought, StringComparison.OrdinalIgnoreCase) >= 0) // group.Contains(sought)
                {
                    Console.WriteLine(String.Join(",", group));
                }
            }
            
            Console.ReadKey();
        }        
    }
}
