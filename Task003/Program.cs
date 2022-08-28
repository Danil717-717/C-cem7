//  Задача 49: Задайте двумерный массив. Найдите элементы, 
//  у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.
//  Например, изначально массив       Новый массив будет выглядеть 
//  выглядел вот так:                 вот так:
//  1 4 7 2                           1 4 7 2
//  5 9 2 3                           5 81 2 9
//  8 4 2 4                           8 4 2 4


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

// void SquareNumber(int [,] CreateMatrix)
// {
//     for(int row = 0; row < CreateMatrix.GetLength(0); ++row)                  
//     {
//         for(int column = 0; column < CreateMatrix.GetLength(1); ++column)
//         {
//             if (row % 2 != 0 && column % 2 != 0) CreateMatrix[row, column] = CreateMatrix[row, column]*CreateMatrix[row, column];
//         }
//     }
// }

void SquareNumber(int [,] CreateMatrix)
{
    for(int row = 0; row < CreateMatrix.GetLength(0); row++)                  
    {
        for(int column = 0; column < CreateMatrix.GetLength(1); column++)
        {
            if (row % 2 != 0 && column % 2 != 0)
            {
                Console.Write($"*{CreateMatrix[row, column] * CreateMatrix[row, column]}\t");
            } 
            else Console.Write($"{CreateMatrix[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(6, 6, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
SquareNumber(matrix); 
//PrintMatrix(matrix);
