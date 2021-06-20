using System;

public class ElectronicsShop
{
    public static int ElectronicsShop(int b, int n, int m, int[] keyboards, int[] drives)
    {
        int result, price;
        result = -1;
        List<int> prices = new List<int>();

        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
               price = keyboards[i] + drives[j];
               
               if(price <= b)
                    result = price;
            }
        }

        return result;
    }
}