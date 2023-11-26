using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"Hello", "2", "world", ":-)"};
            NewArray(array);
        }

        static string[] NewArray (string[] array)
        {
            int value = 3;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= value)
                    count++;
            }

            string[] resultArray = new string[count];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= value)
                {
                    resultArray[j] = array[i];
                    j++;
                }
            }

            /*for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }*/

            return resultArray;
        }
    }
}