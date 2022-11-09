/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
int[,] IntitMatrix(int m, int n)
	{
	    Random rnd = new();
	    int[,] matrix = new int[m,n]; 
	    for (int i = 0; i < m; i++)
	    {
	        for (int j = 0; j < n; j++)
	        {
	            matrix[i,j]= rnd.Next(1,20);
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
int[,] ChangeRowCol (int[,] matrix)
{
    int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    {
        
       for (int i = 0; i < matrix.GetLength(0); i++)
       {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                resultMatrix[j,i] = matrix[i,j];
            }
       }
       return resultMatrix;
    }
    
}

int m = GetNumber("введите число строк ");
int n = GetNumber("Введите количество столбцов ");
if (m != n)
{
    Console.WriteLine("Преобразование невозможно");
}
else
{
int[,] matrix = IntitMatrix(m,n);
PrintArray(matrix);
int[,] resultMatrix = ChangeRowCol(matrix);
PrintArray(resultMatrix);
}