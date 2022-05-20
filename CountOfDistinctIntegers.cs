using System.Collections.Generic;
using System.IO;
using System;

public class Result
{
    static List<int> board = new List<int>();
    static List<int> temporaryBoard = new List<int>();
    static List<int> secondTemporaryBoard = new List<int>();
        
    public static int countDistinctIntegers(int n)
    {
        // First item is added
        board.Add(n);
        temporaryBoard.Add(n);
        
        int numberOfElementSecondaryTemporaryTable = secondTemporaryBoard.Count;
        
        do{               
         foreach(int item in temporaryBoard){
             // Find other possible items
             for(int i = 1; i < item; i++){
                 if(item % i == 1){
                     if(!board.Contains(item - i)){
                     board.Add(item - i);
                     secondTemporaryBoard.Add(item - i);
                     }
                 }
             }              
         }
        
         numberOfElementSecondaryTemporaryTable = secondTemporaryBoard.Count;
        
         if(numberOfElementSecondaryTemporaryTable > 0){
         temporaryBoard = new List<int>();
        
             foreach(int element in secondTemporaryBoard){
                 temporaryBoard.Add(element);
             }
        
         secondTemporaryBoard = new List<int>();      
         }
        }while(numberOfElementSecondaryTemporaryTable > 0);
        
        // The final number of elements in list is the result
        return board.Count;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.countDistinctIntegers(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
