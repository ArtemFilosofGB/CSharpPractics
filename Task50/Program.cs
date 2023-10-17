// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
                startNumber+=k;
            }

        }
        return matrix;

    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] result = new int[2];//[0..1]
        result[1] = 1;// код шибки
        if (rowPosition <= matrix.GetLength(0)
            && columnPosition <= matrix.GetLength(1)
            && rowPosition >= 0
            && columnPosition >= 0) // разобраться с крайними значениями
        {
            result[0] = matrix[rowPosition, columnPosition]; ;
            result[1] = 0;
        }
        else
        {
            result[1] = 1;
        }
        return result;
    }




    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        // Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition 
        // и числа x и y - позиции элемента в матрице. Метод должен проверить, 
        // был ли найден элемент в матрице по указанным координатам (x и y), 
        // используя результаты из метода FindNumberByPosition. 
        // Если такого элемента нет, вывести на экран "There is no such index". 
        // Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
        if (results[1] == 0)
        {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
        else
        {
            Console.WriteLine("There is no such index");
        }

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 0;
            y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}


/*
Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.

Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
*/