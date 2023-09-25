// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.



int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void SqereNumbers (int num)
{
    int count =1;
    while (count<=num)
    {
        Console.WriteLine($"{count,3}->{count*count,5}");
        count++;
    }

}

int x = GetUserInput("Введите число");
SqereNumbers(x);