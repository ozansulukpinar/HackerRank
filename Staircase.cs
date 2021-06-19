using System;

public class Program
{
    public static void Staircase(int n){
        for(int i = 0; i < n; i++){
            // Give space
            for(int j = 0; j < (n - 1 - i); j++){
                Console.Write(" ");
            }

            // Draw symbol
            for(int k = i; k >= 0; k--){
                if(k == 0){
                    Console.WriteLine("#");
                }
                else{
                    Console.Write("#");
                }
            }
        }
    }
}