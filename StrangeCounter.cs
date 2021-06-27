using System;

public class Program
{
    public static int StrangeCounter(int t){
        int result, time, countingValue;
        result = time = 0;

        int startValue = 3;
        countingValue = startValue;

        while(countingValue > 0){
            time++;

            if(time == t)
                break;  
            
            countingValue--;

            if(countingValue == 0){
                startValue *= 2;
                countingValue = startValue;
            }
        }

        result = countingValue;

        return result;
    }
}