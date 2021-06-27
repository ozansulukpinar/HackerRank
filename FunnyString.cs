using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static string FunnyString(string s){
        string result = "Funny";

        List<byte> ASCIICodes = Encoding.ASCII.GetBytes(s).ToList();
        List<int> differences = new List<int>();

        int length = ASCIICodes.Count;

        for(int i = 0; i < length - 1; i++){            
            int difference = ASCIICodes[i + 1] - ASCIICodes[i];

            differences.Add(difference);
        }

        List<int> reverseDifferences = differences.ToList();

        differences.Reverse();

        for(int i = 0; i < length - 1; i++){
            if(differences[i] != reverseDifferences[i]){
                result = "Not " + result;
                break;
            }
        }

        return result;
    }
}