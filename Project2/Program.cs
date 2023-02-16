// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

Console.WriteLine("Сколько столбцов в массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько строчек в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
int [,] table = new int [n,m];

void FillArray(int[,] matrix)
{
    for (int columns = 0; columns < matrix.GetLength(0); columns++)
    {
        for (int rows = 0; rows < matrix.GetLength(1); rows++)
        {
            matrix[columns,rows] = matrix[columns,rows] = new Random().Next(1,10);
            Console.Write($"{matrix[columns,rows]} ");
        }
        Console.WriteLine();
    } 
}

void SearchArray(int[,] matrix)
{
    Console.WriteLine("Какой столбик?");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Какая строчка?");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    for (int columns = 0; columns < matrix.GetLength(0); columns++)
    {
        for (int rows = 0; rows < matrix.GetLength(1); rows++)
        {
            if (columns == a & rows == b)
            {
                result = matrix[columns,rows];
            }
        }
    } 
    if (result == 0)
    {
        Console.WriteLine("Такого элемента нет");
    }
}

FillArray(table);
SearchArray(table);
