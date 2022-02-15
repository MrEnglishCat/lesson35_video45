// +1) Метод, который выводит на экран строку. Символы, из которых состоит строка, и их количество вводятся пользователем. 
// 2) Написать программу для поиска индекса элемента массива (тип элементов в массиве -int; ). Поиск должен вернуть индекс первого найденного элемента. 

  //////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    
    static int[] GetArray (int minValue, int maxValue, int length)
    {
     Random random = new Random();
     int[] array_1 = new int[length];      

     for (int i = 0; i < array_1.Length; i++)
     {
         array_1[i] = random.Next(minValue,maxValue);
     }    
     return array_1;
    }

    static int[] OutArray (int [] arrayOut)
    {   
       //int [] arrayOut = new int[];   
       for (int i = 0; i < arrayOut.Length; i++)
        {
            Console.Write ($"\t{arrayOut[i]}");
        }
        Console.WriteLine();
     return arrayOut;
    }
    
    static int IndexOf (int[] arrayForSearch, int search)
    {
       for (int i = 0; i < arrayForSearch.Length; i++)
       {
            if (search == arrayForSearch[i])
            {
                return i;
            }

       }
       return -1;
    }

    
    public static void Main()
    {

       /* int countOfUserSymbol = 0;
        string symbolOfUser = "";
        Console.Write("Введите количество символов в строке: ");
        countOfUserSymbol = int.Parse(Console.ReadLine());
        Console.Write("Введите символ из которого будет состоять строка: ");
        symbolOfUser = Console.ReadLine();
        for (int i = 1; i <= countOfUserSymbol; i++)
        {
            Console.Write ($@" {symbolOfUser} ");
        }   
        */

        /////////////////////////////////////
        int search = 0;
        bool check = false;
        int[] myArray =  GetArray(-10, 10, 5);     
        OutArray(myArray);
        Console.Write("Введите элемент для поиска: ");
        search = int.Parse(Console.ReadLine());
        Console.WriteLine($"{IndexOf(myArray, search)}");
    }
}
