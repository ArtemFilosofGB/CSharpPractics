//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetUserInput("Imput numbers. For exit push -q- button");
bool isRuning = true;
while (isRuning)
{
    ConsoleKeyInfo keyInfo = GetImput();
    if (Console.ReadLine)
    {
        
    }
    
}