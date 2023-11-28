﻿/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/
Console.Clear();
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int m, int n)
{
    if (m == n) return m.ToString();
    
    return (m + "\t" + PrintNumbers(m + 1, n));
}

Console.WriteLine(PrintNumbers(m, n));