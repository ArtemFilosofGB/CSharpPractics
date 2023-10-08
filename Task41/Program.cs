//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetUserInputArray(int quantit)
{
    int[] arr = new int[quantit];
    for (int i = 0; i < quantit; i++)
    {
        arr[i] = GetUserInput($"Введите {i + 1} число :");
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}]");// ^1 последний элемент массива

}
int CountArrayPositive(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count++; 
    }
    return count;
}

int quantity = GetUserInput("Введите количество чисел");
int[] array = GetUserInputArray(quantity);
PrintArray(array);
int countPosiyive = CountArrayPositive(array);
Console.WriteLine($"Колличество введённых чисел больше 0 : {countPosiyive}.");


