// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
int FindDegree (int n, int st)
{
    int result=1;
    while(st>0)
    {
      result=n*n;
    }
    //int result=Math.Pow(n,st);
    return result;
}

Console.Write("Input your number: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.Write("Input degree of number: ");
int degree =Convert.ToInt32(Console.ReadLine());
int result=FindDegree(a,degree);
Console.WriteLine($"Result is {result}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
  int SumNum(int number)
  {
    int n = Convert.ToString(number).Length;
    int ad = 0;
    int result = 0;

    for (int i = 0; i < n; i++)
    {
      ad = number - number % 10;
      result = result + (number - ad);
      number = number / 10;
    }
   return result;
  }

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int sumNumber = SumNum(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int n)
{
    int []arr= new int[n];
    for(int index=0;index<n;index++)
    {
    Console.WriteLine("Write your number in arr[i]: \b");
    arr[index]=Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for(int index=0; index<arr.Length;index++)
    Console.Write($"{arr[index]}");
    Console.WriteLine("\b\b]");
}

Console.Write("Enter your number of array: \b");
int num= Convert.ToInt32(Console.ReadLine());
int[]newArr=CreateArray (4);
PrintArray(newArr);