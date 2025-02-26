﻿// Time Complexity : O(n)
// Space Complexity :O(1)
public class BinarySearch
{
    // Returns index of x if it is present in arr[l.. r], else return -1 
    public  int binarySearch(int[] arr, int l, int r, int x)
    {
        //Write your code here
        for(int i = l; i < r; i++)
        {
            if(x== arr[i])
                return i;

        }
        return -1;
    }

    // Driver method to test above 
    public static void Main(String[] args)
    {
        BinarySearch ob = new BinarySearch();
        int[] arr = { 2, 3, 4, 10, 40 };
        int n = arr.Length;
        int x = 10;
        int result = ob.binarySearch(arr, 0, n - 1, x);
        if (result == -1)
            Console.WriteLine("Element not present");
        else
            Console.WriteLine("Element found at index " + result);
        Console.ReadLine();
    }
}
