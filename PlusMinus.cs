using System;
using System.Collections.Generic;

public class Program
{
    public static string[] PlusMinus(int[] numbers){
        string[] result;
        List<int> counts = new List<int>();
        List<string> list = new List<string>();
        
        int numberOfPositive, numberOfNegative, numberOfZero, length;
        numberOfPositive = numberOfNegative = numberOfZero = 0;
        length = numbers.Length;

        foreach(int item in numbers){
            if(item > 0)
                numberOfPositive++;
            
            if(item < 0)
                numberOfNegative++;
            
            if(item == 0)
                numberOfZero++;
        }

        counts = new List<int>{numberOfPositive, numberOfNegative, numberOfZero};

        list = ConvertToString(counts, length);

        result = list.ToArray();

        return result;
    }

    private static List<string> ConvertToString(List<int> counts, int length){
        List<string> list = new List<string>();

        foreach(int item in counts){
            decimal ratio = (decimal)item / (decimal)length;
            string converted = ratio.ToString("N6");

            list.Add(converted);
        }       

        return list;
    }
}