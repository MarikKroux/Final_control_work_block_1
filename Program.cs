// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
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
Console.Write(" -> ");
Console.Write("Итоговые данные ");
PrintArray(ResultArray(stringArray)); //Выполняем условие задачи (длина меньше или равна 3) и выводим на экран только те элементы, 
//которые подходят под условие задачи

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

//Создает новый массив и заполняет только теми элементами, длина которых меньше или равна 3
string[] ResultArray(string[] stringArray)
{
    int count = 0;
    int length = stringArray.Length;
    string[] resultArray = new string[length]; //Создаем новый массив 
    //Заполняем новый массив только теми элементами, длина которых меньше или равна 3 
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            resultArray[count] = stringArray[i];
            count++;
        }
    }
    Array.Resize(ref resultArray, count); //Изменяем количество элементов в массиве до указанной величины (количество получившихся элементов, длина которых меньше или равна 3).
    return resultArray;
}
