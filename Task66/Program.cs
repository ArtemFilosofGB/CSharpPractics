// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int NaturalNumbersSum(int m, int n)
{
    int sum = m;
    // Console.Write($"{sum}+"); //монитор процесса
    if (m == n) return sum;
    if (m < n)
    {
        sum = sum + NaturalNumbersSum(m + 1, n);
        return sum;
    }
    else
    {
        return NaturalNumbersSum(n, m); //для случая когда m >n в первоначальном вызове
    }
}

int m = GetUserInput("Введите М");
int n = GetUserInput("Введите N");
int resultSum = NaturalNumbersSum(m, n);
Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N = {resultSum}");

