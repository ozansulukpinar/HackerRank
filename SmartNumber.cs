using System;
using System.Collections.Generic;

public class Program
{
    public static string[] SmartNumber(int t, int[] n){
        List<string> result = new List<string>(t);
        int factors;

        foreach(int item in n){
            factors = 0;

            for(int i = 1; i <= item; i++){
                if(item % i == 0)
                    factors++;
            }

            string currentResult = "NO";

            if(factors % 2 == 1){
                currentResult = "YES";
            }

            result.Add(currentResult);
        }

        return result;
    }
}