using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int SalesByMatch(int n, int[] socks){
        List<int> numbers = new List<int>();
        List<int> amounts = new List<int>();
        int result, key, times;
        result = 0;

        for(int i = 0; i < n; i++){
            key = socks[i];
            
            if(!numbers.Contains(key)){
                times = 0;           

                for(int j = 0; j < n; j++){
                    if(key == socks[j])
                        times++;
                }

                numbers.Add(key);
                amounts.Add(times / 2);
            }
        }

        foreach(int item in amounts){
            result += item;
        }

        return result;
    }
}