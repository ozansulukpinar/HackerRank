using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int MinimumAbsoluteDifferenceInAnArray(int[] arr){
        int result, length;
        result = length = 0;
        List<int> list = new List<int>();
        List<int> differences = new List<int>();

        list = arr.ToList();
        list.Sort();
        length = list.Count;

        for(int i = 0; i < length - 1; i++){
            int difference = list[i + 1] - list[i];

            differences.Add(difference);
        }

        result = differences.Min();

        return result;
    }
}