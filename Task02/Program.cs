// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
/*//Проверка на ввод числа
while (true)
{
    Console.Write("Введите 1е число: ");
    string text1 = Console.ReadLine();
    Console.Write("Введите 2е число: ");
    string text2 = Console.ReadLine();
    if (int.TryParse(text1, out int number1) && int.TryParse(text2, out int number1))
    {
        Console.WriteLine("Вы ввели допустимые числа");
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
*/

if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (number1 > number2)
    {
        Console.WriteLine("Больше первое число");
    }
    else
    {
        Console.WriteLine("Больше второе число");
    }
}
//Чтобы исключить ввод стрики в поле числа

