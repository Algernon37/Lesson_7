// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Сколько столбцов в массиве?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько строчек в массиве?");
int n = Convert.ToInt32(Console.ReadLine());
double [,] table = new double [n,m];

void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows,columns] = matrix[rows,columns] = new Random().Next(-9,10);
            Console.Write($"{matrix[rows,columns]} ");
        }
        Console.WriteLine();
    } 
}
FillArray(table);
