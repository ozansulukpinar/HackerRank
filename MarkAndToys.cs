using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int MarkAndToys(int n, int k, int[] prices){
        int result, i, toys;
        result = i = toys = 0;

        List<int> priceList = prices.ToList();
        priceList.Sort();

        while(k >= priceList[i]){
            toys++;
            k -= priceList[i];
            i++;

            if(i > n)
                break;
        }

        result = toys;

        return result;
    }
}