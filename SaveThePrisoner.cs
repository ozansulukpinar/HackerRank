using System;
using System.Collections.Generic;

public class Program
{
    public static int SaveThePrisoner(int t = 1, int n, int m, int s){
        int result, index;
        result = 0;
        index = s - 1;
        List<int> prisoners = new List<int>();

        for(int i = 1; i <= n; i++){
            prisoners.Add(i);
        }

        while(m > 0){
            if(index == n)
                index -= n;

            index += 1;

            m--;
        }

        result = prisoners[index - 1];

        return result;
    }
}