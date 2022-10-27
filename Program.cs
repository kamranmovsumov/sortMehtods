using System;

namespace sortMehtods
{
    internal class Program
    {
        static void MyArrItem(int[] myArr)
        {
            Random rand = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                int arrRand = rand.Next(0, 100);
                myArr[i] = arrRand;
            }
        }

        static int FindMax(int[] myArr)
        {
            int max = myArr[0];
            for (int i = 0; i < myArr.Length; i++)
            {
                if (max < myArr[i])
                {
                    max = myArr[i];
                }
            }
            return max;
        }
        static void ShowArr(int[] myArr)
        {
            foreach (int item in myArr)
            {
                Console.WriteLine(item);
            }
        }
        static void CountingSort(int[] myArr)
        {
            int max = FindMax(myArr);
            int[] tempArr = new int[max + 1];
            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < tempArr.Length; j++)
                {
                    if (j == myArr[i])
                    {
                        tempArr[j]++;
                    }
                }
            }
            for (int i = 0, j = 0; i < tempArr.Length; i++)
            {
                if (tempArr[i] != 0)
                {
                    myArr[j] = i;
                    j++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] myArr = new int[10];
            MyArrItem(myArr);
            ShowArr(myArr);
            CountingSort(myArr);
            Console.WriteLine();
            ShowArr(myArr);
        }
    }
}
