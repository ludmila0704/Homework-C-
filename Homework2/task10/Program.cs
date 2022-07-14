// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = firstDigit % 10;
    return secondDigit;
}

if (num > 99 && num < 1000)
{
    int result = SecondNumber(num);
    Console.WriteLine($"{num}  ->  {result}");
}
else Console.WriteLine("Введенное число не трехзначное");