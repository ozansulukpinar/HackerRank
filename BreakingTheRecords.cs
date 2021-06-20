using System;

public class Program
{
    public static string BreakingTheRecords(int n, int[] grades){
        string result = "0 0";
        int mostRecord, leastRecord, numberOfMostRecord, numberOfLeastRecord;
        mostRecord = leastRecord = grades[0];
        numberOfMostRecord = numberOfLeastRecord = 0;

        for(int i = 1; i < n; i++){
            if(mostRecord < grades[i]){
                numberOfMostRecord++;
                mostRecord = grades[i];
            }
            
            if(leastRecord > grades[i]){
                numberOfLeastRecord++;
                leastRecord = grades[i];
            }
        }

        result = numberOfMostRecord + " " + numberOfLeastRecord;

        return result;
    }
}