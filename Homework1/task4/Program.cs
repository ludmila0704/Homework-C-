﻿// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)  
  {
    if (num1 > num3)
        {
         Console.WriteLine($"Максимальное из этих трех чисел {num1}"); 
        }
     else
       {
        Console.WriteLine($"Максимальное из этих трех чисел {num3}");
       }   
  } 
  else 
  {
    if (num2 > num3)
    {
       Console.WriteLine($"Максимальное из этих трех чисел {num2}");
    }
    else
    {
       Console.WriteLine($"Максимальное из этих трех чисел {num3}"); 
    }
  }