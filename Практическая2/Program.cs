﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

double a, b, c;

a = 22;
b = 3;
c = 9;


if (a > b)
{
 if (a > c)
    {
       Console.WriteLine("max:" + a);
    }
 else
    {
       Console.WriteLine("max:" + c);
    }
}

else if (b > c)
{
 Console.WriteLine("max:" + b);
}
else
{
 Console.WriteLine("max:" + c);
}