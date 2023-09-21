// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

//using System;

//using Internal;

//using Internal;

//using Internal;

int number = new Random().Next(10, 100);//99+1
Console.WriteLine($"случайное число из отрезка [10, 99]={number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"наибольшую цифру числа{firstDigit}");
}
else
{
    Console.WriteLine($"наибольшую цифру числа{secondDigit}");
}
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //Тернарный оператор альтернатива if
Console.WriteLine(maxDigit);

// //-----------
// int number = new Random().Next(10, 100); // 99 + 1
// Console.WriteLine($"Cлучайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10; // 78 = 70 + 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // Тернарный оператор ?-тогда : -иначе
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

//Использование метода для решения
Console.WriteLine($"Метод: {MaxDigit(number)}");

int MaxDigit(int num)
{   
    int firstDigit = num / 10; // 78 / 10 = 7
    int secondDigit = num % 10; // 78 = 70 + 8 
    return firstDigit > secondDigit ? firstDigit : secondDigit;;
}


