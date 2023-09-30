// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetUserInput(string msg)
{
    Console.Write($"{msg} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int DegreeOfNumber(int num, int degree)
{

    int result = 1;
    for (int i = 0; i < degree; i++)//0..(degree-1)
    {
        result = result * num;
    }
    return result;

}


// bool IsNatural(int natNum)
// {
//     if (degree < 1)
//     {
//         Console.WriteLine("Ошибка: Степень числа не натуральное число");
//         return -1;
//     }
//     else return true;
// }

bool IsPositiveInteger(int posNumber)
{
    if (posNumber <= 0)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(posNumber); i++)
    {
        if (posNumber % i == 0)
        {
            return false;
        }
    }

    return true;
}

int number = GetUserInput("Ведите целое число А");
int degreeOfNumber = GetUserInput("Введите степень А (натуральное число)");
bool isPositiveInteger = IsPositiveInteger(degreeOfNumber);
if (isPositiveInteger == true)
{
    int resultDegree = DegreeOfNumber(number, degreeOfNumber);
    Console.WriteLine($"{number} в степени {degreeOfNumber} = {resultDegree}");
}
else
{
    Console.WriteLine("Ошибка: Неверный ввод");
}
