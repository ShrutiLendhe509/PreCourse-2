using System.Reflection;

public class MergeSort
{
    // Merges two subarrays of arr[]. 
    // First subarray is arr[l..m] 
    // Second subarray is arr[m+1..r] 
    public void merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two
        // subarrays to be merged
        int leftArrayLength = m - l + 1;
        int rightArrayLength = r - m;
        // Create temp arrays
        int[] leftTempArray = new int[leftArrayLength];
        int[] rightTempArray = new int[rightArrayLength];
        int i, j;
        // Copy data to temp arrays
        for (i = 0; i < leftArrayLength; ++i)
            leftTempArray[i] = arr[l + i];
        for (j = 0; j < rightArrayLength; ++j)
            rightTempArray[j] = arr[m + 1 + j];
        // Merge the temp arrays

        // Initial indexes of first
        // and second subarrays
        i = 0;
        j = 0;

        // Initial index of merged
        // subarray array
        int k = l;
        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftTempArray[i] <= rightTempArray[j])
            {
                arr[k++] = leftTempArray[i++];
            }
            else
            {
                arr[k++] = rightTempArray[j++];
            }
        }

        // Copy remaining elements
        // of L[] if any
        while (i < leftArrayLength)
        {
            arr[k++] = leftTempArray[i++];
        }
        // Copy remaining elements
        // of R[] if any
        while (j < rightArrayLength)
        {
            arr[k++] = rightTempArray[j++];
        }
    }

    // Main function that sorts arr[l..r] using 
    // merge() 
    public void sort(int[] arr, int l, int r)
    {
        //Write your code here
        //Call mergeSort from here 

        if (l < r)
        {
            // Find the middle
            // point
            int mid = l + (r - l) / 2;

            // Sort first and
            // second halves
            sort(arr, l, mid);
            sort(arr, mid + 1, r);

            // Merge the sorted halves
            merge(arr, l, mid, r);
        }


    }

    /* A utility function to print array of size n */
    public static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.WriteLine(arr[i] + " ");
        Console.WriteLine();
    }

    // Driver method 
    public static void Main(String[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Given Array");
        printArray(arr);

        MergeSort ob = new MergeSort();
        ob.sort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted array");
        printArray(arr);


        Console.ReadLine();
    }
}