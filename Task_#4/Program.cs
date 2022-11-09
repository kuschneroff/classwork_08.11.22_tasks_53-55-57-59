/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

int[,] IntitMatrix(int m, int n)
{
    Random rnd = new();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
(int row, int col) FindMininum(int[,] matrix)
{
    int minRow = 0;
    int minCol = 0;
    int minimum = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minimum)
            {
                minRow = i;
                minCol = j;
                minimum = matrix[i, j];
            }
        }
    }
    return (minRow, minCol);
}
int[,] GetResultMatrix(int[,] matrix, int rowNumber, int columnNumber)
{
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int countRow = 0;
    int countCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        countCol = 0;
        if (rowNumber == i) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (columnNumber == j)
            {
                continue;
            }
            else
            {
                resultMatrix[countRow, countCol] = matrix[i, j];
                countCol++;
            }
        }
        countRow++;
    }
    return resultMatrix;
}

int m = GetNumber("Введие количство строк ");
int n = GetNumber("Введите количество столбцов ");
int[,] matrix = IntitMatrix(m, n);
PrintArray(matrix);
(int row, int col) = FindMininum(matrix);
Console.WriteLine($"{row}, {col}");
int[,] resultMatrix = GetResultMatrix(matrix, row, col);
PrintArray(resultMatrix);
