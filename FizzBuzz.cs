using System;

public class Result
{
    public static void fizzBuzz(int n)
    {
        for(int j = 1; j <= n; j++ ){
            if(j % 3 == 0){
                if(j % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else{
                    Console.WriteLine("Fizz");
                }
            }
            
            if(j % 5 == 0 && j % 3 != 0)
                Console.WriteLine("Buzz");
            
            if(j % 5 != 0 && j % 3 != 0)
                Console.WriteLine(j);
        }
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
