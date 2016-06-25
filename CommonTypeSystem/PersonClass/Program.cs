using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var gosho = new Person("Gosho", 21);
            var pesho = new Person("Pesho", null);

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}
