using System;

public class Program
{
    public static string TimeConversion(string s){
        string result = "";

        bool isItAm = s.EndsWith("AM");
        bool isItTwelve = s.StartsWith("12");
        s = s.TrimEnd('M');

        if(isItAm){
            if(isItTwelve){
                s = s.TrimStart('1');
                s = s.TrimStart('2');
                s = "00" + s;
            }

            s = s.TrimEnd('A');
        }
        else{ // It is PM
            if(!isItTwelve){
                string start = s.Substring(0, 2);
                int number = Int16.Parse(start);
                number += 12;

                char[] charArray = start.ToCharArray();

                foreach(char item in charArray){
                    s = s.TrimStart(item);
                }

                s = number + "" + s;
            }

            s = s.TrimEnd('P');
        }

        result = s;

        return result;
    }
}