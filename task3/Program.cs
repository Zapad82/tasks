/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

int userNumber = new int();
int minusNumber = new int();
int plusNumber = new int();
int step1 = new int();
Console.WriteLine("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());
minusNumber = -userNumber;
plusNumber = userNumber;
step1 = minusNumber;
while (step1 <= plusNumber)
{
    Console.WriteLine(step1);
    step1 = step1 + 1;
}