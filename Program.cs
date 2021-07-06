using System;

namespace jump_search
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int key = 5;

            int result = jumpSearch(array, key);

            Console.WriteLine(result);

        }

        static int jumpSearch(int[] arr, int key)
        {
            int len = arr.Length;

            int jump = (int)Math.Floor(Math.Sqrt(len));

            int previous = 0;

            //find the block
            while(arr[Math.Min(jump, len) - 1] < key)
            {
                previous = jump;
                jump += (int)Math.Floor(Math.Sqrt(len));

                if (previous >= len)
                    return -1;
            }
            //linear search
            while(arr[previous] < key)
            {
                previous++;

                if (arr[previous] == key)
                    return previous;

                if (previous == Math.Min(jump, len))
                    return -1;
            }
            //item found
            

            
            return -1;
        }
    }
}
