// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrarRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}


void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1} | ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

//int 4 байта, double 8 байт создаём метод для определения позиции макс и мин элемента

double MaxElementDoubleArr(double[] arr)
{
   
    double max = arr[0];
  
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max=arr[i];
      
        }
    }
    return max;
}

double MinElementDoubleArr(double[] arr)
{
   
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
   
        }
    }
    return min;
}

double DoubleDiferents(double num1, double num2)
{
    return num1-num2;
}


double[] array = CreateArrarRndDouble(5,0,100);
PrintArrayDouble(array);
Console.Write(" => ");
double maxDoubleArr = MaxElementDoubleArr(array);
double minDoubleArr = MinElementDoubleArr(array);

Console.Write($"{maxDoubleArr:F1} - {minDoubleArr:F1} = {DoubleDiferents(maxDoubleArr,minDoubleArr):F1}");
