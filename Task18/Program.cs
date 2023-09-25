// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).



int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string RangeCoordinats(int quater)
{
    if (quater == 1) return "x > 0 y > 0";
    if (quater == 2) return "x < 0 && y > 0";
    if (quater == 3) return "x < 0 && y < 0";
    if (quater == 4) return "x > 0 && y < 0";

    return null;

}

int quaterInput = GetUserInput("Ведите четверть:");
string rangeCoordinats = RangeCoordinats(quaterInput);
string result = rangeCoordinats != null
                ? $"Диапазон координат указанной четверти:{rangeCoordinats}"
                : "Некоректный ввод";
Console.WriteLine(result);


