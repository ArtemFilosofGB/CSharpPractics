// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое положительно число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

if (number < 0)
{
    Console.WriteLine("Error: Введено отрицательное число!");
}
else
{
    Console.Write("Все чётные числа от 1 до N:");
    while (index <= number)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index} ");
        }
        index += 1;
    }
}