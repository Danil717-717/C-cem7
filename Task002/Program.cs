//  Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//  m = 3, n = 4.
//  0 1 2 3
//  1 2 3 4
//  2 3 4 5

int [,] CreateMatrix(int rowCount, int columnCount)     
{
    int[,] array = new int[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)                  
    {
        for(int column = 0; column < columnCount; ++column)
        {
            array[row, column] = row + column;  
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

Console.ForegroundColor = ConsoleColor.Blue;
int[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);


