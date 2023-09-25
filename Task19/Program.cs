// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

using System;


public class Answer
{
    static bool IsPalindrome(int number)
    {

        // if (number < 10000 || number >= 100000){
        //     Console.WriteLine("Число не пятизначное");
        //     return false;
        // }

        // int reverse = 0;
        // int temp = number;
        // while (temp > 0){
        //     reverse = reverse * 10 + temp % 10;
        //     temp /= 10;
        // }
        // return reverse == number;
        // Введите свое решение ниже
        if (number >= 10000 && number <= 99999)
        {
            if ((number / 10000 == number % 10) && (number / 1000 % 10 == number % 100 / 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}