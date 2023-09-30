// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System.Globalization;
using System.Reflection;


int GetUserInput(string msg)
{
    Console.Write($"{msg} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int CountDigit(int num)
{

    if (num<0) num*=-1;

    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int number = GetUserInput("Введите число");

int contDigit = CountDigit(number);

Console.WriteLine($"Сумма цифрв числе {number} = {contDigit}");