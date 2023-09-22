// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//using Internal;





int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsNumDigitConst(int num, int digitConst)//проверка порядка
{
    int count = 0;
    while (num != 0)
    {
        Console.WriteLine(count);
        num /= 10;
        count++;
    }
    return count == digitConst ? true : false;
}

int SecondDigit(int num)
{
    return (num / 10) % 10;
}
//Основной код
int number = GetUserInput("Введите трёхзначное число");
if (IsNumDigitConst(number, 3))//3 - разрядность 
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цтфра числа: {result}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}
