using System.IO;
using System;

public class Result
{
    public static int maxPerksItems(int cartridges, int dollars, int recycleReward, int perksCost)
    {
        for(int i = 1; i < cartridges; i++){
            int currentDollars = i * recycleReward + dollars;
            int currentCartridges = cartridges - i;
            
            int neededDollarsForPerks = currentCartridges * perksCost;
            
            if(neededDollarsForPerks <= currentDollars){
                return currentCartridges;
            }            
        }
        
        return 0;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int cartridges = Convert.ToInt32(Console.ReadLine().Trim());

        int dollars = Convert.ToInt32(Console.ReadLine().Trim());

        int recycleReward = Convert.ToInt32(Console.ReadLine().Trim());

        int perksCost = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.maxPerksItems(cartridges, dollars, recycleReward, perksCost);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
