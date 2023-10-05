// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Чи́сла Фибона́ччи (вариант написания — Фибона́чи[2]) — элементы числовой последовательности

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, …

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1)+Fibonacci(n-2);
// }

// for (int i = 1; i < 40; i++) //тормозит после 40
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }




int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

int[] Fibonacci(int n)
{
    int[] arr = new int[n];
    //arr[0]=0;
    arr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;

}

int num = GetUserInput("Введите N >= 2:");
if (num < 2)
{
    Console.WriteLine("Некоректный ввод");
    return;//Завершение main
}

int[] array = Fibonacci(num);
PrintOut(array);