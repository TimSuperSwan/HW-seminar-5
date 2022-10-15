using System;

namespace Семинар5дз
{
    class Program
    {
        static void Main(string[] args)
        {
          
        //____________________ДОМШНЕЕ ЗАДАНИЕ 5 СЕМИНАР________________________

        /*__Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        Напишите программу, которая покажет количество чётных чисел в массиве.
        [345, 897, 568, 234] -> 2 */

        /*
        Console.WriteLine("Введите размерность массива:");
        int SizeArray = int.Parse(Console.ReadLine()!);
        int[] Array = GetArray(SizeArray,100,999);
        int count = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i]%2 == 0) count++;  
        }
        Console.WriteLine($"[{String.Join(", ", Array)}]");
        Console.WriteLine($"В массиве {count} четных чисел");
        // Аж с первого раза с чистого листа никуда не подглядывая и даже без единой ошибки!!! Вау

        */
        
        /*__Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
        стоящих на нечётных позициях.
        [3, 7, 23, 12] -> 19
        [-4, -6, 89, 6] -> 0*/
        /*
        Console.WriteLine("Введите размерность массива:");
        int SizeArray = int.Parse(Console.ReadLine()!);
        int[] Array = GetArray(SizeArray,1,9);
        int Result = 0;
        Console.WriteLine($"[{String.Join(",", Array)}]");
        for (int i = 0; i < Array.Length; i++)
        {
            if (i%2 == 1)
            {
                Result = Result + Array[i];
            }
        }
        Console.WriteLine($"Сумма элементов на нечетных позициях = {Result}");
        */

        /*__Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, 
        до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и 
        минимальным элементов массива.
        [3 7 22 2 78] -> 76 */




        int[] GetArray (int size, int minnum, int maxnum)
        {
            int[] res = new int[size];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new Random().Next(minnum, maxnum+1);
            }
            return res;
        }
        
        
          
          
          
          
          
          
          
          
          
          
          
            
        }
    }
}
