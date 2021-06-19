using System;

public class Program
{
    public static void AppleAndOrange(int s, int t, int a, int b, int[] m, int[] n){
        FindAmount(s, t, a, m);
        FindAmount(s, t, b, n);
    }

    private static void FindAmount(int s, int t, int c, int[] o){
        int fruit = 0;

        foreach(int item in o){
            int position = item + c;

            if(s <= position && position <= t)
                fruit++;
        }

        Console.WriteLine(fruit);
    }
}