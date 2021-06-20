using System;

public class Program
{
    public static DateTime DayOfTheProgrammer(int year){
        string dayOfTheProgrammer = "";
        DateTime date = new DateTime();
        int dayOfYear = 256;

        date = new DateTime(year, 1, 1).AddDays(dayOfYear - 1);
        dayOfTheProgrammer = date.ToString("dd.MM.yyyy");

        return dayOfTheProgrammer;
    }
}