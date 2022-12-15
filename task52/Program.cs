// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
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

int[] ScanMatrix(int rows, int columns, int[,] matrix)
{
    int[] array = new int[columns];
    int summaValue = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            summaValue = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                summaValue += matrix[i,j];
            }
            array[j] = summaValue;
    }
    return array;
}

double[] MeddleValue(int[] array, double rows, int columns)
{
    double[] arrayD = new double[columns];
    for (int i = 0; i < arrayD.Length; i++)
    {
        arrayD[i] = Math.Round(Convert.ToDouble(array[i] / rows), 2);
    }
    return arrayD;
}

void PrintMeddleValue(double[] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int z = 0; z < array.Length; z++)
    {
        if (z < array.Length - 1) Console.Write($"{array[z]}; ");
        else Console.Write($"{array[z]}.");
    }
}

Console.WriteLine($"Создание матрицы");
Console.Write($"Сколько будет строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сколько будет столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, columns);
PrintMatrix(array2D);
int[] array = ScanMatrix(rows, columns, array2D);
double[] arrayD = MeddleValue(array, rows, columns);
PrintMeddleValue(arrayD);