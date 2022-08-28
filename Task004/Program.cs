//   Задача 51: Задайте двумерный массив.
//  Найдите сумму элементов, 
//   находящихся на главной диагонали 
//   (с индексами (0,0); (1;1) ит.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

int Sumnumber(int [,] matrix)
{
    int result = 0;
    for(int row = 0; row < matrix.GetLength(0); row++)                  
    {
        for(int column = 0; column < matrix.GetLength(1); column++)
        {
            if (row == column) result += matrix[row, column];
        }     
    }
    return result;
}    

int[,] matrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
int diagonal = Sumnumber(matrix); 
Console.WriteLine($"Summ: {diagonal}");