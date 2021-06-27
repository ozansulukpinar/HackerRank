using System;
using System.Text;

public class Program
{
    public static int CamelCase(string sentence){
        int result = 1;

        byte[] bytes = Encoding.ASCII.GetBytes(sentence);

        foreach(byte item in bytes){
            if(65 <= item && item <= 90)
                result++;
        }

        return result;
    }
}