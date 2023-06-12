using System.Collections.Generic;
// Task №1
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число b:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число c:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N:");
        int n = Convert.ToInt32(Console.ReadLine());


       Console.WriteLine($"Наибольшее число из {a} и {b} => {TaskOne(a, b) }");
       Console.WriteLine($"Наибольшее число из {a},{b},{c} => {TaskTwo(a,b,c)}");
       TaskThee(n);
       TaskFour(n);
    }



static int TaskOne(int a, int b)
{
    if (a > b)
        {
           return a;
        }
        return b;
}
static int TaskTwo(int a, int b, int c)
{
    if (a > b && a > c)
        {
           int max = a;
           return max;
        }
    else if (b > c && b > a) 
     {
        int max = b;
        return max;
     }
     else
      return c;
}
static void TaskThee(int n)
{
    if( n%2 == 0 )
    {
     Console.WriteLine($"Число {n} четное");
    }
    else
     Console.WriteLine($"Число {n} нечетное");   
}
static void TaskFour(int n)
{
    for (int i = 1; i <= n; i++) 
    {
          if( i % 2 == 0 )
          {
            System.Console.WriteLine($"Четные числа: {i}");
          }
    }   
}
}
