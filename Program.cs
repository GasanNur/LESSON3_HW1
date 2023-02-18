// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да

using System;

class Palindr
     {
        public static bool Palindromtest (string s)
        {
               for (int i = 0, j = s.Length - 1; i < j; i++, j--)
 
                    if (s[i] == s[j]) 
                        return true; 
                        return false;                   
        }
          

    static void Main()
        {
        string s;
            Console.WriteLine("Анализ палиндромов \n\n Введите строку:");
          s = Console.ReadLine();
           if (Palindromtest(s))
       Console.WriteLine("Эта строка - палиндром");
       else Console.WriteLine("Эта строка - не палиндром");
    Console.ReadLine();
        }
}