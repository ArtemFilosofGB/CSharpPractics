// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//using Internal;

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool DivisionTo(int num, int num1, int num2)
{
    return num%num1==0 && num % num2 ==0;
}

int number = GetUserInput("Enter number");
bool div7a23 = DivisionTo(number,7,23);
Console.WriteLine(div7a23 ? "да": "нет"); //тернарный оператор