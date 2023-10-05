// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

// [1 2 3 4 5] -> [5 4 3 2 1]

//Array.Reverse(array)
void ReverseArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i]=arr[arr.Length-i-1];
        arr[arr.Length-i-1]=temp;
    }
}

int[] array= CreateArrRndInt(5,1,9);
PrintOut(array);
Console.WriteLine();
ReverseArray(array);
PrintOut(array);