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
                for (int j = i - 1; j >= 0; j--)
                {
                    if (myArr[index] < myArr[j])
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
            QuickSort(myArr, 0, myArr.Length - 1);
        }
        #region QuickSort
        static void QuickSort(int[] myArr, int low, int high)
        {
            if (low >= high)
                return;
            int pivot = myArr[high];
            int pivotNewIndex = Partition(myArr, low, high, pivot);
            QuickSort(myArr, low, pivotNewIndex - 1);
            QuickSort(myArr, pivotNewIndex + 1, high);
        }

        static int Partition(int[] myArr, int low, int high, int pivot)
        {
            int j = low;
            for (int i = low; i <= high; i++)
            {
                if (myArr[i] <= pivot)
                {
                    int temp = myArr[i];
                    myArr[i] = myArr[j];
                    myArr[j] = temp;
                    j++;
                }
            }
            return j - 1;
        }
        #endregion

        #region MergeSort
        static void MergeSort(int[] myArr)
        {
            MergeSort(myArr, 0, myArr.Length - 1);
        }

        static void MergeSort(int[] myArr, int left, int right)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            MergeSort(myArr, left, middle);
            MergeSort(myArr, middle + 1, right);

            Merge(myArr, left, middle, right);
        }

        static void Merge(int[] myArr, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            int leftIndex = 0, rightIndex = 0;

            for (int i = left; i <= middle; i++)
            {
                leftArray[leftIndex] = myArr[i];

                leftIndex++;
            }

            for (int i = middle + 1; i <= right; i++)
            {
                rightArray[rightIndex] = myArr[i];

                rightIndex++;
            }

            int mainIndex = left;
            leftIndex = 0;
            rightIndex = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] < rightArray[rightIndex])
                {
                    myArr[mainIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    myArr[mainIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                mainIndex++;
            }

            while (leftIndex < leftArray.Length)
            {
                myArr[mainIndex] = leftArray[leftIndex];

                mainIndex++;
                leftIndex++;
            }

            while (rightIndex < rightArray.Length)
            {
                myArr[mainIndex] = rightArray[rightIndex];

                mainIndex++;
                rightIndex++;
            }
        }
        #endregion

        #region Binary Search
        static int BinarySearch(int[] myArr, int element)
        {
            return BinarySearch(myArr, element, 0, myArr.Length - 1);
        }

        static int BinarySearch(int[] myArr, int element, int left, int right)
        {
            if (left > right)
                return -1;
            int middle = (left + right) / 2;

            if (myArr[middle] > element)
                return BinarySearch(myArr, element, left, middle - 1);

            if (myArr[middle] < element)
                return BinarySearch(myArr, element, middle + 1, right);

            return middle;
        }
        #endregion
        static void Main(string[] args)
        {
            int[] myArr = new int[10];
            MyArrItem(myArr);
            ShowArr(myArr);
            //CountingSort(myArr);
            //SelectionSort(myArr);
            //BubbleSort(myArr);
            //InsertionSort(myArr);
            //QuickSort(myArr);
            //MergeSort(myArr);
            #region BinarySearch
            int element = Convert.ToInt32(Console.ReadLine());
            int index = BinarySearch(myArr, element);
            if (index != -1)
            {
                Console.WriteLine($"Element found. Index: {index}");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            #endregion
            Console.WriteLine();
            ShowArr(myArr);
        }
    }
}
