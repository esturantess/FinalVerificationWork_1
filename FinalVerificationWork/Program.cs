// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма.

int NumberElementsOfSpecifiedLength(string[] array, int size)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size) count++;
    }
    return count;
}

string[] LeaveElementsOfSpecifiedLengthInArray(string[] array, int size)
{
    string[] newArray = new string[NumberElementsOfSpecifiedLength(array, size)];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] array =  { "собака", "кот", "мышь", "бык", "сова", "як",
                    "енот", "сыч", "орангутан", "Питер Петтигрю" };

string[] newArray = LeaveElementsOfSpecifiedLengthInArray(array, 3);
Console.WriteLine("[" + String.Join(", ", newArray) + "]");