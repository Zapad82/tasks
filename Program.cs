/*
Задача 28: Напишите программу, которая принимает на вход число N
и выдаёт произведение чисел от 1 до N. 4 -> 24 5 -> 120 

int[] arr = new int[8]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
for (int i = 0; i < arr.Length; i++)
{
//Создание объекта для генерации чисел
Random rnd = new Random();
//Получить случайное число (в диапазоне от 0 до 10)
int value = rnd.Next(0, 2);
arr[i] = value;
Console.Write($"{arr[i]} ");
}
}

RandomArray(arr); 
*/

/*Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int ProdNum(int number)
{
    int prodNumber = 1;
    for (int i = 1; i <= num; i++)
    {
        prodNumber *= i;
    }
    return prodNumber;
}
Console.WriteLine($"Произведение чисел от 1 до {num} = {ProdNum(num)}");*/


Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int factorial(int number)
{
int fact = 1;
for (int i = 1; i <= num; i++)
{
fact *= i;
}
return fact;
}

Console.WriteLine($"Факториал {factorial(num)}"); 