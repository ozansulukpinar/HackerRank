using System;

public class Program
{
    public static string Pangrams(string s){
        string result = "pangram";
        int count = 0;

        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] letters = alphabet.ToCharArray();
        
        s = s.ToLower();
        char[] sentenceLetters = s.ToCharArray();

        foreach(char item in letters){
            foreach(char element in sentenceLetters){
                if(item == element){
                    count++;
                    break;
                }
            }
        }

        if(count != 26)
            result = "not " + result;

        return result;
    }
}