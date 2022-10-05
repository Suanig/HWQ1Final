Console.WriteLine("Создание массива для выполнения.\nВведите длину массива");
int countArrayValue = int.Parse(Console.ReadLine());

string[] startArray = new string[countArrayValue];

string[] FillArray(string[] array)
{
    for (int i = 0; i < countArrayValue; i++)
    {
        Console.WriteLine($"Введите {i} значение для заполнения массива:");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] array)
{
    int countNV = 0;
    string arrayValue = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3) countNV++;
    }

    string[] endArray = new string[countNV];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3)
        {
            endArray[index] = array[i];
            index++;
        }
    }
    return endArray;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Заданных значений нет.");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  {array[i]}");
    }
}

FillArray(startArray);

string[] endArray = SortArray(startArray);

Console.WriteLine("\n Изначальный массив:");
PrintArray(startArray);

Console.WriteLine("\n Массив значений с длинной (<) либо = (3) символа:");
PrintArray(endArray);