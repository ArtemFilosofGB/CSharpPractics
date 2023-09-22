// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//третью слева

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int IsNumDigitConst(int num)//проверка порядка
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

//------------------------------------------------------------------------
int number = GetUserInput("Введите число от -2147483648 до +2147483647 :");

int countDigit = IsNumDigitConst(number);
Console.WriteLine($"Порядок числа = {countDigit}");

if (countDigit < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (countDigit > 3)
    {
        number = number / 10;
       // Console.WriteLine(number);//процесс превращение заданого числа в трёхзначное уменьшением порядка слева
        countDigit--;
    }
    Console.WriteLine($"Третья цифра числа {number%10}");
}


