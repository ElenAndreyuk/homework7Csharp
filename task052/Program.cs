// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("Введите количество строк ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
double [,] array = new double[m, n];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 5);

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
System.Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];
    }
    average = sum / array.GetLength(1);
    System.Console.WriteLine($"Среднее арифметическое столбца {j}: {average}");
    
}



