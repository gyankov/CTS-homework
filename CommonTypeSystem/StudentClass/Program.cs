using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var gosho = new Student("Gosho", "Goshov", "Goshov", 9536478, "Daleko", "646854654",
                2, Specialty.Geodesy, Universities.UACEG, Faculties.second);

            var pesho = new Student("Pesho", "Peshov", "Peshov", 89465468, "Blizo", "658874688",
                3, Specialty.Informatics, Universities.TU, Faculties.first);


            Console.WriteLine(gosho.Equals(pesho));
          
        }
    }
}
