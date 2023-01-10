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
        decimal duong = 0, am = 0, khong = 0;
        int count = arr.Count;
        foreach (int value in arr)
        {
            if (value > 0)
                duong++;
            else if (value < 0)
                am++;
            else
                khong++;
        }
        duong /= count;
        am /= count;
        khong /= count;
        Console.WriteLine(duong.ToString("0.000000"));
        Console.WriteLine(am.ToString("0.000000"));
        Console.WriteLine(khong.ToString("0.000000"));
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
