using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        float positive = 0;
        float negative = 0;
        float zero = 0;
        int count = arr.Count;
        
        for(int i = 0; i < count; i++)
        {
            if(arr[i] > 0)
            {
                positive++;
            }
            else if(arr[i] < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
        }
        Console.WriteLine(positive / count);
        Console.WriteLine(negative / count);
        Console.WriteLine(zero / count);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
