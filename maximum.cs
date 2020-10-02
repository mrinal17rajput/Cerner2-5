// C# program to find the maximum 
// cerner_2^5_2020
// j – i such that arr[j] > arr[i] 
using System; 
class GFG { 
    // For a given array arr[], returns 
    // the maximum j-i such that arr[j] > arr[i] 
    static int maxIndexDiff(int[] arr, int n) 
    { 
        int maxDiff = -1; 
        int i, j; 
  
        for (i = 0; i < n; ++i) { 
            for (j = n - 1; j > i; --j) { 
                if (arr[j] > arr[i] && maxDiff < (j - i)) 
                    maxDiff = j - i; 
            } 
        } 
  
        return maxDiff; 
    } 
  
    // Driver program 
    public static void Main() 
    { 
  
        int[] arr = { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 }; 
        int n = arr.Length; 
        int maxDiff = maxIndexDiff(arr, n); 
        Console.Write(maxDiff); 
    } 
} 