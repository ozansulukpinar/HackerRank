using System;

public class Program
{
    public static int SherlockAndSquares(double start, double end){
        int result = 0;

        for(double i = start; i <= end; i++){
            double squareRoot = Math.Sqrt(i);

            if(squareRoot % 1 == 0)
                result++;
        }
        
        return result;
    }
}