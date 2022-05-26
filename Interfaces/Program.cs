using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main()
        {
            Libro[] biblioteca = new Libro[3];
            biblioteca[0] = new Libro("Robert C. Martin", "Clean Code");
            biblioteca[1] = new Libro("William Hohl", "ARM Assembly Language");
            biblioteca[2] = new Libro("Marijn Haverbeke", "Eloquent JavaScript");

            Array.Sort(biblioteca);

            foreach (Libro libro in biblioteca)
            {
                Console.WriteLine(libro.Describir());
            }
        }
    }
}
