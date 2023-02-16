//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


double N;
        
N = 8;
double index;
index = 1;

while (index <= N)
{
    Console.WriteLine(index % 2 == 0);
    Console.WriteLine(index);
    index = index + 1;
}