using System;
using System.Collections.Generic;

public class Program
{
    public static int BeautifulDaysAtTheMovies(int i, int j, int k){
        int result = 0;

        for(int m = i; m <= j; m++){
            bool isDivisible = false;

            isDivisible = IsItDivised(m, k);

            if(isDivisible)
                result++;
        }

        return result;
    }

    private static bool IsItDivised(int day, int k){
        bool result = false;
        int reverseDay, digit, length, currentDay;
        reverseDay = digit = length = 0;
        currentDay = day;
        List<int> digits = new List<int>();

        while(day > 0){
            digit = day % 10;
            day /= 10;
            digits.Add(digit);
        }

        length = digits.Count;
        digits.Reverse();

        for(int i = 0; i < length; i++){
            int tenPower = 1;

            for(int j = 0; j < i; j++){
                tenPower *= 10;
            }

            int number = tenPower * digits[i];

            reverseDay += number;
        }

        int difference = currentDay - reverseDay;

        if(difference < 0)
            difference *= -1;

        if(difference % k == 0)
            result = true;

        return result;
    }
}