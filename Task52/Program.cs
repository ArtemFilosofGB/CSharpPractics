// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t"); // формат вывода в 5 символов
            }
            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        int startNumber = 1;

        for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1)
            {
                matrix[i, j] = startNumber;
                startNumber += k;
            }
        }
        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are:");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"{list[i]:f2}\t");

        }


    }


    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        int resultSize = (matrix.GetLength(0) > matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1);
        double[] results = new double[resultSize];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {   
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                results[j] += Convert.ToDouble(matrix[i, j]); //  results[j] для суммы столбцов  results[i] для строк
            }
            //results[j] = results[j] / matrix.GetLength(1);
        }
        for (int i = 0; i < results.Length; i++)
        {
            results[i]= results[i]/matrix.GetLength(0);
        }
        return results;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}

/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
с каждым новым элементом увеличивающимся на определенное число. 
Метод принимает на вход три числа 
(n - количество строк матрицы, 
m - количество столбцов матрицы, 
k - число, на которое увеличивается каждый новый элемент) 
и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

Метод FindAverageInColumns 
принимает целочисленную матрицу типа int[,] 
и возвращает одномерный массив типа double. 
Этот метод вычисляет среднее значение чисел в каждом столбце матрицы 
и сохраняет результаты в виде списка.

Метод PrintListAvr принимает одномерный массив, 
возвращенный методом FindAverageInColumns 
и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...",
 где x.x0 - это значения средних значений столбцов,
  округленные до двух знаков после запятой 
  (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода),
   разделенные знаком табуляции.
   */