using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int FindTheMedian(int n, int[] array){
        int result = 0;

        List<int> list = array.ToList();
        list.Sort();

        int middleIndex = n / 2;

        result = list[middleIndex];

        return result;
    }
}