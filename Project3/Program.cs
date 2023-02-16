// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Сколько столбцов в массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько строчек в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
int [,] table = new int [n,m];

void FillArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows,columns] = matrix[rows,columns] = new Random().Next(1,10);
            Console.Write($"{matrix[rows,columns]} ");
        }
        Console.WriteLine();
    } 
}

void Number(int[,] matrix)
{   
    double result = 0;
    double sum = 0;
    
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            sum += matrix[rows, columns];
            result = sum / matrix.GetLength(0);
        }
        Console.Write($"{result} ");
    }
}

FillArray(table);
Number(table);