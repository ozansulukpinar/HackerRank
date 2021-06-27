using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
    public static string CaesarCipher(string s, int k){
        string encryted = "";

        byte[] bytes = Encoding.ASCII.GetBytes(s);
        List<char> chars = new List<char>();

        foreach(byte item in bytes){
            int element = item;

            if(65 <= element && element <= 90){
                element += 32;
                element += k;

                if(element > 122)
                    element -= 26;

                element -= 32;
            }

            if(97 <= element && element <= 122)
                element += k;

            if(element > 122)
                element -= 26;

            chars.Add(Convert.ToChar(element));
        }

        foreach(char item in chars){
            encryted += item;
        }

        return encryted;
    }
}