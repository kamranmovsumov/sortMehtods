using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFirstApp
{
    class Program
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

        static void SelectionSort(int[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                int min = myArr[i];
                int minIndex = i;
                for (int j = i + 1; j < myArr.Length; j++)
                {
                    if (myArr[j] < min)
                    {
                        min = myArr[j];
                        minIndex = j;
                    }
                }
                int temp = myArr[i];
                myArr[i] = myArr[minIndex];
                myArr[minIndex] = temp;
            }
        }

        static void CountingSort(int[] myArr)
        {
            int max = FindMax(myArr);
            int[] tempArr = new int[max + 1];
            for (int i = 0; i < myArr.Length; i++)
            {
                tempArr[myArr[i]]++;
                //for (int j = 0; j < tempArr.Length; j++)
                //{
                //    if (j == myArr[i])
                //    {
                //        tempArr[j]++;
                //    }
                //}
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

        static void BubbleSort(int[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < myArr.Length - 1 - i; j++)
                {
                    if (myArr[j] > myArr[j + 1])
                    {
                        int temp = myArr[j];
                        myArr[j] = myArr[j + 1];
                        myArr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }

        static void InsertionSort(int[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                int index = i;
                for (int j = i-1; j >=0; j--)
                {
                    if (myArr[index]<myArr[j])
                    {
                        int temp = myArr[index];
                        myArr[index] = myArr[j];
                        myArr[j] = temp;
                        index = j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void QuickSort(int[] myArr)
        {

        }



        static void Main(string[] args)
        {
            int[] myArr = new int[10];
            MyArrItem(myArr);
            ShowArr(myArr);
            //CountingSort(myArr);
            //SelectionSort(myArr);
            //BubbleSort(myArr);
            //InsertionSort(myArr);
            QuickSort(myArr);
            Console.WriteLine();
            ShowArr(myArr);
        }
    }
}
