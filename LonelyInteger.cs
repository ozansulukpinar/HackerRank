using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int LonelyInteger(int n, int[] a){
        int result, count = 0;

        List<int> integers = a.ToList();
        
        foreach(int item in integers){
            count = 0;

            for(int i = 0; i < n; i++){
                if(item == integers[i])
                    count++;
            }

            if(count == 1){
                result = item;
                return result;
            }
        }
    }
}