// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] SortArray(string[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) index++;
    }
    string[] tempArr = new string[index];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tempArr[j] = array[i];
            j++;
        }
    }
    return tempArr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] array = { "Hello", "World", "2", ":-)", "1234", "156", "-2", "computer science" };
Console.Write("Original array: ");
PrintArray(array);
array = SortArray(array);
Console.Write("Result array: ");
PrintArray(array);