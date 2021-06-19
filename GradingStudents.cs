using System;
using System.Collections.Generic;

public class Program
{
    public static int[] GradingStudents(int n, int[] grades){
        List<int> list = new List<int>();
        
        for(int i = 0; i < n; i++){
            int grade = grades[i];

            if(grades[i] >= 38){
                int round = grade % 5;

                switch(round){
                    case 0:
                    case 1:
                    case 2:
                        // No rounding
                        break;
                    case 3:
                        grade += 2;
                        break;
                    case 4:
                        grade++;
                        break;
                }
            }

            list.Add(grade);          
        }
        
        int[] result = list.ToArray();

        return result;
    }
}