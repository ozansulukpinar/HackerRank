using System;
using System.Collections.Generic;

public class Program
{
    public static int FindDigits(int number){
        int result, digit, currentNumber;
        result = digit = 0;
        currentNumber = number;
        List<int> digits = new List<int>();

        while(number > 0){
            digit = number % 10;
            number /= 10;
            digits.Add(digit);
        }

        foreach(int item in digits){
			if(item == 0)
				continue;

            if(currentNumber % item == 0)
                result++;
        }

        return result;
    }
}