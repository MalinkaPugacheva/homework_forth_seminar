//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
/*
Console.WriteLine("Input number of rows: ");
int rowsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colomns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rowsVol, columnsVol];
CreateRandomArray(numbers);
PrintArray(numbers);

void CreateRandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/
//Задача 50: Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
/*
Console.WriteLine("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
CreateRandomArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("There is no such element");
}
else
{
    Console.WriteLine($"The meening of element {n} row и {m} column is {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
*/

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

Console.WriteLine("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
CreateRandomArray(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
