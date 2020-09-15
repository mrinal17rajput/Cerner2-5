package com.mrinal;

import java.util.Scanner;
//cerner_2^5_2020
//Given an array of N integers. Find the contiguous sub-array with maximum sum.
public class MaxSubArraySum {
    public static void main (String[] args)
    {
        System.out.println("Enter test cases");
        /* Sample input:
           2           -- number of test cases(n)
           5           -- number of elements in 1st array
           1 2 3 -2 5  -- elements
           4           -- number of elements in nth array
          -1 -2 -3 -4  -- elements
        */
        Scanner sc = new Scanner(System.in);
        int testCases = sc. nextInt();
        int prev, currMax, size;
        for(int j = 0; j < testCases; j++){
            size = sc.nextInt();
            // setting prev as the first element of array
            prev = sc.nextInt();
            currMax = prev;
            for(int i = 0; i< size -1; i++){
                int element = sc.nextInt();
                // setting prev as the max of the current element or the sum of current element and prev
                prev = Math.max(element, element + prev);
                // after each updation, set the currMax value with max value between prev and currMax
                currMax = Math.max(prev, currMax);
            }
            // In the last, currMax will have the maximum contiguous sub-array sum
            System.out.println(currMax);
        }
    }
}
