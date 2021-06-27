using System;
using System.Text;

public class Program
{
    public static string GridChallenge(int n, string[] grid){
        string result = "NO";
        string element = "";

        foreach(string item in grid){
            element += item;
        }

        byte[] bytes = Encoding.ASCII.GetBytes(element);

        int length, start, i;
        length = n * n;
        start = i = 0;

        while(start < n){
            i = start;

            while(i < n * (n - 1)){
                if(bytes[i] > bytes[i + n]){
                    return result;
                }
                else{
                    i += n;
                }
            }

            start++;
        }

        if(start == n)
            result = "YES";

        return result;
    }
}