// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
void Palindrom(int number)
{
    int firstDigit = number / 10000; //первая цифра
    int lastDigit = number % 10;    //последняя цифра

    if (firstDigit == lastDigit)
    {
        int fourthDigit = (number / 10) % 10;  //четвертая цифра
        int secondDigit = (number / 1000) % 10; //вторая цифра

        if (fourthDigit == secondDigit) Console.WriteLine("Это число - палиндром!");
        else Console.WriteLine("Это число не палиндром.");
    }
    else Console.WriteLine("Это число не палиндром.");

}
if (num > 9999 && num < 100000) Palindrom(num);
else Console.WriteLine("Введенное число не пятизначное");
