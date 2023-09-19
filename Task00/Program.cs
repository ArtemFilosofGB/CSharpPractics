// Квадрат числа
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.Write("Квадрат числа " + number + " = ");
//Console.Write(number * number);
int squere = number * number;
Console.WriteLine($"{number} -> {squere}");
