using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Properties
{
    class Dz_Array
    {
        private int[] array;



        public Dz_Array(int size)
        {
            array = new int[size];
        }



        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value * value;
            }

        }
    }
}
