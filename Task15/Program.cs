// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет




int GetUserInputDay(string str) //Метод принимающий цифру обозначающию день недели
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    if (num<1 || num>7)
    {
        return -1;//возвращает -1 если выходит из диапазона 1..7
    }
    return num;
}

bool IsDayWeekend(int day)//метод проверящий выходной деньно номеру дня недели 
{
    if((day == 6) || (day==7)) 
    {
        return true;
    }
    else
    {
        return false;
    }

}

int dayNum = GetUserInputDay("Введите цифру,обозначающую день недели :");
if (dayNum!=-1)
{
    if (IsDayWeekend(dayNum))
    {
        Console.WriteLine("Да выходной");
    }
    else
    {
        Console.WriteLine("Нет, будний день");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}