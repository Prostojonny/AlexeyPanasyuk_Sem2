﻿// // // //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // // 456 -> 5
// // // 782 -> 8
// // // 918 -> 1
// // // */

// // int number = ReadInt("Введите трехзначное число: ");
// // int amount = number.ToString().Length;

// // if (amount < 3 || amount > 3)
// // {
// //     Console.WriteLine("Вы ввели не трехзначное число");
// // }
// // else
// // {
// //     Console.WriteLine(InCenter(number));
// // }



// // // ФУНКЦИИ------------------------------------------------------------------------------------------------------

// // // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
// // int ReadInt(string message)
// // {
// //     Console.Write(message);
// //     return Convert.ToInt32(Console.ReadLine());
// // }

// // // Функция вывода цифры стоящей в середине трехзначногно числа.
// // int InCenter(int a)
// // {
    
// //     int result = ((a / 10) % 10);
// //     return result;
// // }






// // Задача 2
// // 645 -> 5;
// // 78 -> третьей цифры нет
// // 32679 -> 6

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));


// // ФУНКЦИИ------------------------------------------------------------------------------------------------------

// // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }











// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

int promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool isweekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}
bool validateweekday(int number)
{
    if (number>0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine ("не тот день недели");
    return false;
}
int weekday = promt("введите нужный день");
if(validateweekday(weekday))
{
    if (isweekend(weekday))
    {
        Console.WriteLine("ура! Выходной!");
    }
    else
    {
        Console.WriteLine ("улыбаемся и пашем!");
    }
}