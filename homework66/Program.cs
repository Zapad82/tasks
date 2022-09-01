/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

Console.Clear();

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());

void EvenNumberSum (int numberM, int numberN, int sum)
{
        if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM+2);
    EvenNumberSum(numberM, numberN, sum);
}

EvenNumberSum(numberM, numberN, 0);