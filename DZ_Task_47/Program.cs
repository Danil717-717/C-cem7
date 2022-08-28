// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7    -2    -0,2
// 1   -3,3   8    -9,9
// 8    7,8  -7,1   9

double [,] CreateMatrix(int rowCount, int columnCount)     
{
    double[,] array = new double[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)                  
    {
        for(int column = 0; column < columnCount; ++column)
        {
            array[row, column] =  new Random().NextDouble()*100;

        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for(int row = 0; row < array.GetLength(0); ++row)                  
    {
        for(int column = 0; column < array.GetLength(1); ++column)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }    
           
}

double[,] matrix = CreateMatrix(6, 3);
PrintMatrix(matrix);