// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArrRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

int CountEvenElements(int[] arr)
{
    int positiveCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i]%2==0) positiveCount++;
    //  Console.WriteLine($"= {arr[i]} - {i} - {arr[i]%2==0} ="); // визуализация проверки на чётность
    }
    return positiveCount;
}

void PrintOut(int[] arr)
{   
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}]");// ^1 последний элемент массива

}

int[] array = CreateArrRndInt(4,100,1000); //[100..999]
PrintOut(array);
Console.WriteLine();

int countPositiveElements = CountEvenElements(array);
Console.WriteLine($"Количество чётных чисел в массиве: {countPositiveElements}");
