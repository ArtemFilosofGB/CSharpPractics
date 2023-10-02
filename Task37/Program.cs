// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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


// double[] CreateArrRndDouble(int size, int min, int max)
// {
//     double[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.NextDouble() * (max - min) + min;
//     }

//     return arr;
// }



int[] ProductOfPairNumbers(int[] numbers)
{
    int size = numbers.Length /2 + numbers.Length%2; //размер результирующего массива
    int[] productOfPairs= new int[size];
    for (int i = 0; i < size; i++)
    {
        productOfPairs[i] = numbers[i]+numbers[numbers.Length-1-i];
    }
    return productOfPairs;
}

void PrintOut(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

int[] Array = CreateArrRndInt(5,1,9);
PrintOut(Array);
Console.WriteLine();
int[] resArr = ProductOfPairNumbers(Array);
PrintOut(resArr);
