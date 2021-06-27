using System;
using System.Text;

public class Program
{
    public static string TwoStrings(string s1, string s2){
        string result = "NO";

        byte[] bytesOfs1 = GetBytesOfString(s1);
        byte[] bytesOfs2 = GetBytesOfString(s2);

        foreach(byte item in bytesOfs1){
            foreach(byte element in bytesOfs2){
                if(item == element){
                    result = "YES";
                    return result;
                }
            }
        }

        return result;
    }

    private static byte[] GetBytesOfString(string s){
        byte[] bytes = Encoding.ASCII.GetBytes(s);

        return bytes;
    }
}