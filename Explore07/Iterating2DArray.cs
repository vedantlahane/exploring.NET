using System;

class Iterating2DArray
{
    public static void Iterate()
    {
        int[,] matrix =
        {
            {1, 2},
            {3, 4}
        };

        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                Console.WriteLine(matrix[i, j]);
            }
        }
    }
}