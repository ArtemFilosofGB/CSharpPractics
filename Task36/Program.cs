// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    int sumElements = 0;
    for (int i = 1; i < arr.Length; i++)
    {
      if (i%2!=0) sumElements += arr[i];
      //Console.WriteLine($"= {arr[i]} = {i} = {i%2==0} = {sumElements} ="); // визуализация проверки на нечётность
    }
    return sumElements;
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

int[] array = CreateArrRndInt(4,-6,90); //исходя из примеров в условии
PrintOut(array);
Console.WriteLine();

int sumEvenElements = CountEvenElements(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sumEvenElements}");