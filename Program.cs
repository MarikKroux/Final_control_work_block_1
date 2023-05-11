﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Программа принимает введенные данные и выводит результат, состоящий из строк, длина которых меньше, либо равна 3 символам.\n");

int N = 0;
InitInputByUser(ref N); //Уточняем количество элементов, которые хочет ввести пользователь
string[] stringArray = new string[N]; //Создаем массив, равный количеству элементов
FillStringArray(stringArray); //Запускаем функцию заполнения пользователем массива
Console.WriteLine("\nРезультат: ");
Console.Write("Введенные данные ");
PrintArray(stringArray); //Выводим на экран введенные данные пользователем

//----------------------------------------------------------------------------

// Функция, выполняющая проверку на корректность введенного количества планируемых элементов (с проверкой x < 0 - ошибка)
void InitInputByUser(ref int N)
{
    while (true)
    {
        try
        {
            Console.Write("Введите количество элементов: ");
            N = int.Parse(Console.ReadLine() ?? "");
            if (N < 0)
            {
                Console.WriteLine("Ошибка! Введите число больше 0!\n");
                InitInputByUser(ref N);
            }
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! Необходимо ввести число! {exc.Message}\n");
        }
    }
}

//Заполнение массива пользователем
void FillStringArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        stringArray[i] = Console.ReadLine() ?? ""; //Заполняем массив данными, введенными с клавиатуры
    }
}

//Вывод массива
void PrintArray(string[] array)
{
    if (array.Length == 0) //Если элементы в одной из частей отсутствуют - выведет []
        Console.Write("[]");
    else
    {
        Console.Write("[\"");
        Console.Write(string.Join("\", \"", array));
        Console.Write("\"]");
    }
}