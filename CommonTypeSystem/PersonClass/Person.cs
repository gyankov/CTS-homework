using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Person
    {
        public Person(string name, int? age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int? Age { get; set; }


        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Name: " + this.Name+ "\r\n");
            if (this.Age!=null)
            {
                result.Append("Age: " + this.Age);
            }
            else
            {
                result.Append("Age is not specified");
            }
            result.AppendLine();

            return result.ToString();

        }
    }
}
