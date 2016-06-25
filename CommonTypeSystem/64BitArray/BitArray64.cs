using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    class BitArray64: IEnumerable
    {
        private ulong[] array;

        public BitArray64(int length)
        {
            this.array = new ulong[length];
        }

        public ulong[] Array
        {
            get
            {

                return this.array;

            }
        }

        public int Length
        {
            get
            {
                return this.array.Length;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                yield return array[i];
            }
        }
         public ulong this[int number]
        {
            get
            {
                if (number<0 || number>=this.array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return array[number];
                }
            }

            set
            {
                if (number < 0 || number >= this.array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {

                     array[number]=value;
                }
            }
        }


        public override bool Equals(object obj)
        {
            var anotherArr = obj as BitArray64;
            if (anotherArr == null)
            {
                throw new ArgumentException;
            }

            if (this.Length==anotherArr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override int GetHashCode()
        {
            return this.array.GetHashCode() ^ this.array.Length;
        }

        public static bool operator ==(BitArray64 firstArr, BitArray64 secondArr)
        {
            return BitArray64.Equals(firstArr, secondArr);
        }

        public static bool operator !=(BitArray64 firstArr, BitArray64 secondArr)
        {
            return !BitArray64.Equals(firstArr, secondArr);
        }

       // couldn't find anything about overriding [], it wouldn't  allow me to override it as operator
      
    }


}
