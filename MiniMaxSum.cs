using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void MiniMaxSum(int[] numbers){
        List<int> list = new List<int>();
        List<int> newList = new List<int>();
        List<int> sumsOfNumbers = new List<int>();

        foreach(int item in numbers){
            list.Add(item);
        }

        int length = list.Count;

        for(int i = 0; i < length; i++){
            List<int> copyList = list.ToList();
            copyList.RemoveAt(i);
            newList = copyList;

            int sum = newList.Sum();
            sumsOfNumbers.Add(sum);
        }

        string result = sumsOfNumbers.Min() + " " + sumsOfNumbers.Max();

        Console.Write(result);
    }
}