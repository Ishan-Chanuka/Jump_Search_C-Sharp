using System;

namespace jump_search
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 7;

            int result = Convert.ToInt32(jumpSearch(array, key));

            Console.WriteLine(result);

        }

        static int jumpSearch(int[] arr, int key)
        {
            int len = arr.Length;

            int jump = (int)Math.Floor(Math.Sqrt(len));


            for (int i=0; i<len; i += jump)
            {
               
            }
            return -1;
        }
    }
}
