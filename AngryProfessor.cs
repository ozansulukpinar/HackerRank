using System;

public class Program
{
    public static string[] AngryProfessor(int t = 1, int n, int k, int[] times){
        string result = "NO";
        int numberOfStudents = 0;

        for(int i = 0; i < n; i++){
            if(times[i] > 0){
                numberOfStudents++;
            }
        }

        if(numberOfStudents < k)
            result = "YES";

        return result;
    }
}