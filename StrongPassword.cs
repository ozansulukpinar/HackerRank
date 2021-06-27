using System;
using System.Collections.Generic;

public class Program
{
    public static int StrongPassword(string password){
        int result, length;
        result = 0;

        char[] chars = password.ToCharArray();
        length = chars.Length;

        string numbers = "0123456789";
        string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string specialCharacters = "!@#$%^&*()-+";

        List<string> criterias = new List<string>(){numbers, lowerCase, upperCase, specialCharacters};
        List<int> counts = new List<int>(4){0, 0, 0, 0};

        foreach(char item in chars){
            for(int i = 0; i < 4; i++){
                if(criterias[i].Contains(item.ToString()))
                    counts[i] += 1;
            }
        }

        foreach(int item in counts){
            if(item == 0)
                result++;
        }

        if(length < 6){
			int difference = 6 - length;
			
			if(difference > result)
				result = difference;
        }

        return result;
    }
}