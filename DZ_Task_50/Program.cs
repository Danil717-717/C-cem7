// Задача 50: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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


void ExaminationNum(int[,] array)
{

    Console.WriteLine("Введите координаты числа");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > array.GetLength(0) && b > array.GetLength(1))
        Console.WriteLine($"Числа с координатами {a} {b} нет");
    else
    {
        object c = array.GetValue(a, b);
        Console.WriteLine($"Число с координатами {a} {b} -> {c}");
    
    }
}

Console.WriteLine("Введите колличество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = CreateMatrix(m, n, 0, 99);
PrintMatrix(matrix);
ExaminationNum(matrix);