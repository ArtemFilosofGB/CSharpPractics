// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue) //Метод, который создает двумерный массив
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //Метод, который выводит двумерный массив в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[] FindLowerValueRowCol(int[,] matrix)
{
    int rowNum = 0;
    int colNum = 0;
    int[] res = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowNum, colNum])
            {
                rowNum = i;
                colNum = j;
            }

        }
    }
    return new int[] { rowNum, colNum };

}

int[,] MatrixRowColDelByCoords(int[,] matrix, int rowTodel, int colTodel)
{
    int[,] resMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int row = 0;
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        if (i == rowTodel) row++;
        int col = 0;
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            if (j == colTodel) col++;
            resMatrix[i, j] = matrix[row, col];
            col++;
        }
        row++;
    }
    return resMatrix;
}

int[,] customMatrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(customMatrix);
Console.WriteLine();
int[] coords = FindLowerValueRowCol(customMatrix);
Console.WriteLine($"row {coords[0]} , {coords[1]} min val = {customMatrix[coords[0], coords[1]]}");
int[,] resultArr = MatrixRowColDelByCoords(customMatrix,coords[0], coords[1]);
PrintMatrix(resultArr);

