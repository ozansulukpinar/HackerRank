using System;

public class Program
{
    public static int[] CompareTheTriplets(int[] array1, int[] array2){
        int[] result = {0,0};

        for(int i = 0; i < 3; i++){
            if(array1[i] > array2[i]){
                result[0]++;
            }
            else if(array1[i] < array2[i]){
                result[1]++;
            }
            else{
                // They are equal
            }
        }

        return result;
    }
}