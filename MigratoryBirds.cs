using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int MigratoryBirds(int n, int[] birds){
        int result, key, time, max;
        List<int> times = new List<int>();
        List<int> indexes = new List<int>();
        result = time = max = 0;

        for(int i = 0; i < n; i++){
            time = 0;
            key = birds[i];

            foreach(int item in birds){
                if(item == key)
                    time++;
            }

            times.Add(time);
        }

        max = times.Max();

        for(int i = 0; i < n; i++){
            if(times[i] == max)
                indexes.Add(i);
        }

        int indexesLength = indexes.Count;
        result = birds[indexes[0]];

        if(indexesLength != 1){
            for(int i = 0; i < indexesLength; i++){
                if(birds[indexes[i]] < result)
                    result = birds[indexes[i]];
            }
        }

        return result;
    }
}