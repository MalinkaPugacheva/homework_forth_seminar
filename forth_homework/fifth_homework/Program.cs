// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray (int n)
{
    int []newArray=new int[n];
    for(int i=0;i<n;i++)
        newArray[i]= new Random().Next(100,1000);
    return newArray;
}

void PrintArray(int[]array)
{
    for(int i=0;i< array.Length;i++)
    Console.Write(array[i]+ " ");
    Console.WriteLine();
}

int QuantityEvenNum(int[]array)
{
    int q=0;
    for (int i=0;i>0;i++)
    {
    i%=2;
     q++;
    }
    return q;     
}
Console.Write("Input size of array: ");
int size=Convert.ToInt32(Console.ReadLine());

int[]newArray=CreateRandomArray(size);
PrintArray(newArray);

Console.Write($"Quantity of even numbers in array is {QuantityEvenNum(newArray)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray (int n, int min, int max)
{
    int []newArray=new int[n];
    for(int i=0;i<n;i++)
        newArray[i]= new Random().Next(min,max+1);
    return newArray;
}

void PrintArray(int[]array)
{
    for(int i=0;i< array.Length;i++)
    Console.Write(array[i]+ " ");
    Console.WriteLine();
}

int FindSum (int []array)
{
    int sum=0;
    for(int i=0;i< array.Length;i+=2)
        sum+=array[i];
     return sum;
}

Console.Write("Input size of array: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number of array: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number of array: ");
int max=Convert.ToInt32(Console.ReadLine());

int[]newArray=CreateRandomArray(n,min,max);
PrintArray(newArray);

Console.Write($"Sum of numbers in odd array position is {FindSum(newArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//new Random().Next (min,max+1) + NextDouble()
/*
void FillDiffMaxMin(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillDiffMaxMin(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Difference of maximum number {max} and minimum number {min} = {max - min}");
*/