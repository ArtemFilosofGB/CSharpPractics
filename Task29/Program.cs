// Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




int GetUserInput(string msg)
{
    Console.Write($"{msg}");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int[] GenerateArray(int Lenght, int min, int max)
{
    int[] array = new int[Lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;

}

void PrintArray(int[] arr)
{
    string str = "[" + Convert.ToString(arr[0]);
    for (int j = 1; j < arr.Length; j++)
    {
        str = str + ", " + Convert.ToString(arr[j]);
    }
    str = str + "]";
    Console.WriteLine(str);
}

//int[] array = new int[] { 1, 2, 5, 7, 19, 6, 1, 33 };


int arrayLenght = GetUserInput("Введите колличество элементов массива :");
int minArray = GetUserInput("Минимальное значение массива :");
int maxArray = GetUserInput("Максимальное значение массива :");
int[] resArray = GenerateArray(arrayLenght,minArray, maxArray); //Random array
PrintArray(resArray);

