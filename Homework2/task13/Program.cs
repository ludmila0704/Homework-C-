// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int ThirthDigit (int number)
{ int a =0;
    if (number<100) return -1;
    else
    {
        while (number>100)
        {
           a = number%10;
        //return a;
        number=number/10;
        } return a;
    }//return  0;
}

int result =  ThirthDigit(num);
//if (result!=-1) 

    Console.WriteLine($"{num}  ->  {result}");

//else ($"Третьей цифры в числе {num}  нет.");
