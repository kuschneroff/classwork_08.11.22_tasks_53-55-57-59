/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/

int[,] InitMatrix(int m, int n)
{
    Random rnd = new();
    int[,] matrix = new int[m,n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j]= rnd.Next(1,10);
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Dictionary<int,int> CountNumbers(int[,] matrix)
{
    Dictionary<int, int> resultDict = new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (resultDict.ContainsKey(matrix[i,j]))
            {
                resultDict[matrix[i,j]]+=1;
            }
            else
            {
                resultDict.Add(matrix[i,j], 1);
            }
        }
    }
    return resultDict;
}

void PrintDict(Dictionary<int, int> resultDict)
{
    foreach (var item in resultDict.OrderBy(x => x.Key))
    {
        Console.WriteLine($"{item.Key} встречается {item.Value} раз");
    }
}

int m = GetNumber("Введите количество строк ");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = InitMatrix(m, n);
Dictionary<int, int> resultDict = CountNumbers(matrix);
PrintArray(matrix);
PrintDict(resultDict);
