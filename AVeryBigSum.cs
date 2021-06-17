using System;
using System.Numerics;

public class Program
{
    public static BigInteger AVeryBigSum(int n, BigInteger[] numbers){
        BigInteger result = 0;

        for(int i = 0; i < n; i++){
            result += numbers[i];
        }

        return result;
    }
}