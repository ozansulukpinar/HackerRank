using System;
using System.Collections.Generic;

public class Program
{
    public static int[] UtopianTree(int n, int[] cycles){
        int[] result;
        List<int> list = new List<int>();

        for(int i = 0; i < n; i++){
            int height = FindTheHeight(cycles[i]);

            list.Add(height);
        }

        result = list.ToArray();

        return result;
    }

    private static int FindTheHeight(int cycle){
        int height = 1;

        for(int i = 0; i < cycle; i++){
            bool isItEven = (i % 2 == 0) ? true : false;

            if(isItEven){
                height *= 2;
            }
            else{
                height += 1;
            }
        }

        return height;
    }
}