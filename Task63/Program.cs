//Задача 63: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

NaturalsNumbers(number);

void NaturalsNumbers(int num, int count = 1)
{
    int i = num - count;
    if (num == 0) return;
    Console.Write($"{num - i} ");
    NaturalsNumbers(num - 1, count+1);
}
