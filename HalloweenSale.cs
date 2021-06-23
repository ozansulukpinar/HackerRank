using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int HalloweenSale(int p, int d, int m, int s){
        int result, sum, price;
        result = sum = price = 0;
        List<int> prices = new List<int>();

        sum = prices.Sum();

        while((s - sum) > m){
            if(p > m){
                price = p;
				prices.Add(price);
				
				p -= d;                
            }
            else{
                price = m;
				prices.Add(price);
            }
            
            sum = prices.Sum();
        }

        result = prices.Count;
        
        return result;
    }
}