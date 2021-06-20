using System;

public class Program
{
    public static string NumberLineJumps(int x1, int v1, int x2, int v2){
        string result = "NO";
        int newx1, newx2;
        newx1 = x1 + v1;
        newx2 = x2 + v2;

        while(newx1 <= 20000 && newx2 <= 20000){
            if(newx1 == newx2){
                result = "YES";
                break;
            }

            newx1 += v1;
            newx2 += v2;
        }

        return result;
    }
}