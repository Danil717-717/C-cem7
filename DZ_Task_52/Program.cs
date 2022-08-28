// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 


int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); ++row)
    {
        for (int column = 0; column < array.GetLength(1); ++column)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }

}

void SredneeArifmetic(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticMean += array[j, i];
        }
        arithmeticMean = Math.Round(arithmeticMean / array.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца ->  {arithmeticMean}");
    }
        //Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(double)srAr / array.GetLength(1)}");
}





int[,] matrix = CreateMatrix(3, 4, 0, 9);
PrintMatrix(matrix);
SredneeArifmetic(matrix);