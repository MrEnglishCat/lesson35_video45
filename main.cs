using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    
    static int[] GetArray (int length, int minValue, int maxValue)
    {
     Random random = new Random();
     int[] array_1 = new int[length];      

     for (int i = 0; i < array_1.Length; i++)
     {
         array_1[i] = random.Next(minValue,maxValue);
     }    
     return array_1;
    }

    static int[] OutArray (int[] array_1)
    {
     
       for (int i = 0; i < array_1.Length; i++)
        {
            Console.Write ($"\t{array_1}");
        }
     return array_1;
    }
    
    
    public static void Main()
    {
// +1) Метод, который выводит на экран строку. Символы, из которых состоит строка, и их количество вводятся пользователем. 
// 2) Написать программу для поиска индекса элемента массива (тип элементов в массиве -int; ). Поиск должен вернуть индекс первого найденного элемента. 

  //////////////////////////////////////
       /* int countOfUserSymbol = 0;
        string symbolOfUser = "";
        Console.Write("Введите количество символов в строке: ");
        countOfUserSymbol = int.Parse(Console.ReadLine());
        Console.Write("Ввкдите символ из которого будет состоять строка: ");
        symbolOfUser = Console.ReadLine();
        for (int i = 1; i <= countOfUserSymbol; i++)
        {
            Console.Write ($@" {symbolOfUser} ");
        }   
        */

        /////////////////////////////////////
        int search = 0;
        bool check = false;
        int[] myArray =  GetArray(-10, 10, 10);
        OutArray (myArray);

     
     Console.Write("Введите элемент для поиска: ");
     search = int.Parse(Console.ReadLine());

     for (int i = 0; i < myArray.Length; i++)
     {
        if (search == myArray[i])
        {
          Console.WriteLine($"Элемент найден. Индекс элемента {search} - {i}");         
          check = true;
           break;
        }
           
     }  
     if (check == false)
     {
         Console.WriteLine($"Элемент не найден.");
     }
    }
}