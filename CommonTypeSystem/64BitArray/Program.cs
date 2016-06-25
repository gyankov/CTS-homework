using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new BitArray64(4);
            arr[2] = 123424143;
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arr.GetHashCode());

        }
    }
}
