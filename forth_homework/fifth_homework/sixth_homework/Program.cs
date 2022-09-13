// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
/*
Console.Clear();

Console.Write($"Input number М(the amount of numbers): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
       Console.Write($"Input {i+1} number: ");
       massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"The amount of numbers more than 0: {Comparison(massiveNumbers)} ");
*/
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void WriteRatio()
{
  for (int i = 0; i < ratio.GetLength(0); i++)
  {
    Console.Write($"Input ratio {i+1} first equation (y = k * x + b):\n");
    for (int j = 0; j < ratio.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Input ratio k: ");
      else Console.Write($"Input ratio b: ");
      ratio[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
