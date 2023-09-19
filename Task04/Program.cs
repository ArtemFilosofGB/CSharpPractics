// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число:");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 && number1 == number3)
{
    Console.WriteLine("Вы ввели три одинаковых числа!");
}
else
{
    int max = number1;
    if (number2 > number1)
    {
        max = number2;
    }
    if (number3 > max)
    {
        max = number3;
    }

    Console.WriteLine("Максимальное число :");
    Console.WriteLine(max);
}