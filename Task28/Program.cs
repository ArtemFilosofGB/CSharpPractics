// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
//Факториал

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Factorial(int num)
{
    int fac = 1;
    for (int i = 1; i <= num; i++)
    {
        checked //проверка на переполнение типа
        {
            fac *= i;
        }
    }
    return fac;
}

int number = GetUserInput("Enter a number");
int fact = Factorial(number);

Console.WriteLine($"Произведение чисел от 1 до {number} -> {fact}");