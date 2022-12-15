// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, "); //форматирование отступ на 4 
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}
int AddX()
{
    Console.WriteLine($"Поиск элемента в двумерном массиве ");
    Console.Write($"Введи параметр строки в массиве: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int AddY()
{    
    Console.Write($"Введи параметр столбца в массиве: ");
    int y = Convert.ToInt32(Console.ReadLine());
    return y;
}
int ScanMatrix(int rows, int columns, int[,] matrix, int x, int y)
{
    int scanElement = 0;
    Console.WriteLine($"строка - {x}, столбец - {y}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == x && j == y) 
            {
                scanElement = matrix[i,j];
            }            
        }
    }
    return scanElement;
}
void PrintScanMatrix (int printElement)
{
    if (printElement != 0) 
        Console.WriteLine($"Значение элемента равно {printElement}");
    else
        Console.WriteLine($"Такого элемента нет!");
}

Console.WriteLine($"Поиск элемента в двумерном массиве ");
Console.WriteLine($"Создание матрицы");
Console.Write($"Сколько будет строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сколько будет столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, columns);
PrintMatrix(array2D);
PrintScanMatrix(ScanMatrix(rows, columns, array2D, AddX(), AddY()));
