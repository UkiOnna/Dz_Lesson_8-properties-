using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out size);
            Dz_Array array = new Dz_Array(size);
            Random random = new Random();
            int maxSizeForRandom = 50;



            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(maxSizeForRandom);
                Console.Write("{0}  ",array[i]);
            }

            Console.ReadLine();

        }
    }
}
