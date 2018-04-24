using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 4, 5, 6 };
            SimpleBisect(arr,3);
            Console.WriteLine(SimpleBisect(arr, 3));
        }
        public static int? SimpleBisect(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return null;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] > target)
                {
                    right = middle - 1;
                }
                else if (array[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return null;
        }

    }
}
