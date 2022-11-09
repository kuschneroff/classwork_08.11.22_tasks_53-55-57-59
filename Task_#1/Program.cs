/*Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

int[,]CreateArray(int num1, int num2)
	{
	    int[,]array=new int[num1,num2];
	    Random rnd =new Random();
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	      for (int j = 0; j < array.GetLength(1); j++)
	      {
	        array[i,j]=rnd.Next(1,9);
	      }  
	    }
	    return array;
	}
	void PrintArray(int[,]array)
	{
	     for (int i = 0; i < array.GetLength(0); i++)
	    {
	      for (int j = 0; j < array.GetLength(1); j++)
	      {
	        Console.Write($"{array[i,j]} ");
	      }  
	      Console.WriteLine();
	    }
	    Console.WriteLine();
	}
    int[,]ArrayConvert(int[,]array)
	{
	    int [,] resultArray= new int [array.GetLength(0),array.GetLength(1)];
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	      for (int j = 0; j < array.GetLength(1); j++)
	      {
	        if(i==0)
	        resultArray[i,j]= array[array.GetLength(0)-1,j];
	        else if(i==(resultArray.GetLength(0)-1))
	        resultArray[i,j]=array[0,j];
	        else resultArray[i,j]=array[i,j];
	      }  
	      
	    }
	    return resultArray;
	}
	
	int[,] result = CreateArray(5,5);
	PrintArray(result);
	int[,] result2 = ArrayConvert(result);
	PrintArray (result2);