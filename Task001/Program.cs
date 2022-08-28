// Задача 46: Задайте двумерный массив размером m×n,
//  заполненный случайными целыми числами.
//  m = 3, n = 4.
//  1 4 8 19
//  5 -2 33 -2
//  77 3 8 1

int [,] CreateMatrix(int rowCount, int columnCount, int min, int max)     
{
    int[,] array = new int[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)                  
    {
        for(int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min,max + 1);  
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
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

int[,] matrix = CreateMatrix(7, 7, 0, 999);

int length = matrix.Length;         // общее число элементов 
Console.WriteLine($"Общее количество элементов: {length}");                // двумерного массива 
PrintMatrix(matrix);