using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int MarcsCakewalk(int n, int[] calories){
        int result, power;
        result = 0;
        power = 1;

        List<int> list = calories.ToList();
        list.Sort();
        list.Reverse();

        for(int i = 0; i < n; i++){
            list[i] *= power;

            power *= 2;
        }

        result = list.Sum();

        return result;
    }
}