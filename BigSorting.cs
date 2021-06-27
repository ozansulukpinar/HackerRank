using System;
using System.Collections.Generic;
using System.Numerics;

public class Program
{
    public static string[] BigSorting(string[] unsorted){
        List<BigInteger> list = new List<BigInteger>();

        int length = unsorted.Length;
        string[] sorted = new string[length];

        for(int i = 0; i < length; i++){
            BigInteger number = BigInteger.Parse(unsorted[i]);

            list.Add(number);
        }

        list.Sort();

        for(int j = 0; j < length; j++){
            string number = "" + list[j];

            sorted[j] = number;
        }

        return sorted;
    }
}