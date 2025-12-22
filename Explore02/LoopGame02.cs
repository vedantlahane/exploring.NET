using System;

class LoopGame02
{
    public static void Main()
    {
        int skip = 4;
        Console.WriteLine("Game Started \n-----------------------------");
        for(int i = 1; i <= 10; i++)
        {
            if( i == skip)
            {
              Console.WriteLine($"Player Skipped Enemy {i}");
              continue;  
            } 
            Console.WriteLine($"Player Killed Enemy {i}");
        }
        Console.WriteLine("-------------------------------- \nGame Over");
    }
}