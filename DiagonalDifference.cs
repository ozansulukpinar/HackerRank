using System;

public class Program
{
    public static int DiagonalDifference(int n, int[,] numbers){
        int result, sumOfFirstDiagonal, sumOfSecondDiagonal;
        result = sumOfFirstDiagonal = sumOfSecondDiagonal = 0;

        for(int i = 0; i < n; i++){
            sumOfFirstDiagonal += numbers[i, i];
            sumOfSecondDiagonal += numbers[(i),(n - 1 - i)];
        }

        result = sumOfFirstDiagonal - sumOfSecondDiagonal;

        if(result < 0)
            result *= -1;

        return result;
    }
}