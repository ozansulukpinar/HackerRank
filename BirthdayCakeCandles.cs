using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int BirthdayCakeCandles(int n, int[] candles){
        int result = 0;
        List<int> list = new List<int>();

        for(int i = 0; i < n; i++){
            list.Add(candles[i]);
        }

        int max = list.Max();

        for(int i = 0; i < n; i++){
            if(list[i] == max)
                result++;
        }

        return result;
    }
}