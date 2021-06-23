using System;
using System.Collections.Generic;

public class Program
{
    public static int LibraryFine(string returnedDate, string dueDate){
        int result = 0;

        List<int> returnedDateList = ConvertStringToInt(returnedDate);
        List<int> dueDateList = ConvertStringToInt(dueDate);

        int yearDifference = returnedDateList[2] - dueDateList[2];
        int monthDifference = returnedDateList[1] - dueDateList[1];
        int dayDifference = returnedDateList[0] - dueDateList[0];

        if(yearDifference > 0)
            result += result + 10000;

        if(monthDifference > 0)
            result += result + monthDifference * 500;

        if(dayDifference > 0)
            result += result + dayDifference * 15;

        return result;
    }

    private static List<int> ConvertStringToInt(string date){
        string[] dateArray = date.Split(' ');
        List<int> dateNumbers = new List<int>();

        foreach(string item in dateArray){
            int number = Convert.ToInt16(item);
            
            dateNumbers.Add(number);
        }

        return dateNumbers;
    }
}