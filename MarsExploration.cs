using System;

public class Program
{
    public static int MarsExploration(string s){
        int result, length;
        result = 0;
        length = s.Length;
        string key = "SOS";

        for(int i = 0; i < length; i += 3){
            string substring = s.Substring(i, 3);

            if(substring != key)
                result++;
        }

        return result;
    }
}