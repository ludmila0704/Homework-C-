// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число дня недели");
int num = Convert.ToInt32(Console.ReadLine());


bool Weekend(int number)
{
    return number == 6 || number == 7;
}
if (num > 0 && num < 8)
{
    bool res = Weekend(num);
    if (res)
    {
        Console.WriteLine("да.это выходной");
    }
    else Console.WriteLine("нет.это не выходной");
}
else Console.WriteLine("Число не обозначает день недели");