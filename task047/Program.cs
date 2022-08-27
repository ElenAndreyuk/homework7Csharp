// Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);

        }
    }
}
void Print(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}  ");

        }
        System.Console.WriteLine();
    }
}
FillArray(array);
Print(array);
