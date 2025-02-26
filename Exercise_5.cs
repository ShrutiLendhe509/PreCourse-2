﻿class IterativeQuickSort
{
    public void swap(int[] arr, int i, int j)
    {
        //Try swapping without extra variable 
    }

    /* This function is same in both iterative and 
       recursive*/
    public int partition(int[] arr, int l, int h)
    {
        //Compare elements and swap.
        int temp;
        int pivot = arr[h];

        // index of smaller element
        int i = (l - 1);
        for (int j = l; j <= h - 1; j++)
        {

            // If current element is
            // smaller than or
            // equal to pivot
            if (arr[j] <= pivot)
            {
                i++;

                // swap arr[i] and arr[j]
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // swap arr[i+1] and arr[high]
        // (or pivot)
        temp = arr[i + 1];
        arr[i + 1] = arr[h];
        arr[h] = temp;

        return i + 1;
    }

    // Sorts arr[l..h] using iterative QuickSort 
    public void QuickSort(int[] arr, int l, int h)
    {
        //Try using Stack Data Structure to remove recursion.
        if (l < h)
        {
            /* pi is partitioning index,
            arr[pi] is now at right place */
            int pi = partition(arr, l, h);

            // Recursively sort elements
            // before partition and after
            // partition
            QuickSort(arr, l, pi - 1);
            QuickSort(arr, pi + 1, h);
        }
    }

    // A utility function to print contents of arr 
    public void printArr(int[] arr, int n)
    {
        int i;
        for (i = 0; i < n; ++i)
            Console.WriteLine(arr[i] + " ");
    }

    // Driver code to test above 
    public static void Main(String[] args)
    {
        IterativeQuickSort ob = new IterativeQuickSort();
        int[] arr = { 4, 3, 5, 2, 1, 3, 2, 3 };
        ob.QuickSort(arr, 0, arr.Length - 1);
        ob.printArr(arr, arr.Length);
        Console.ReadLine();
    }
}