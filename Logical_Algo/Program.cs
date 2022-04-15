using System;

namespace Logical_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Bubble Sort
            int[] intArr = new int[] { 23, 41, 25, 54, 18, 14 };

            for (int j = intArr.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < intArr.Length - 1; i++)
                {
                    if (intArr[i] > intArr[i + 1])
                    {
                        int temp = intArr[i + 1];
                        intArr[i + 1] = intArr[i];
                        intArr[i] = temp;
                    }
                }
            }

            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Hello World!");


            //2.Selection Sort
            int[] selectArr = new int[] { 23, 41, 25, 54, 18, 14 };


            for (int j = selectArr.Length - 1; j > 0; j--)
            {
                int largestIndex = 0;
                int temp1;
                for (int i = 0; i < j; i++)
                {
                    if (selectArr[largestIndex] < selectArr[i + 1])
                    {
                        largestIndex = i + 1;
                    }

                }
                temp1 = selectArr[largestIndex];
                selectArr[largestIndex] = selectArr[j];
                selectArr[j] = temp1;
            }

            foreach (int i in selectArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Hello World!1");


            //3. Insertion Sort


        }
    }
}

