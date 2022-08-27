// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
int[,] array = {
     {1, 4, 7, 2},
     {5, 9, 2, 3},
     {8, 4, 2, 4}
};
Console.WriteLine("Введите номер строки нужного элемента");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца нужного элемента");
int j = int.Parse(Console.ReadLine());
try
{
    System.Console.WriteLine($"На позиции [{i}, {j}] находится: {array[i, j]}");
}
catch
{
    System.Console.WriteLine("Такого элемента нет");
}