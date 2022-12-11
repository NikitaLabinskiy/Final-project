Console.Clear();

Console.Write("Введите количество слов в массиве: ");

bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

string[] array = new string[x];

FillArray(array);

PrintArray(array);

string[] result = FindTheWords(array);

Console.WriteLine();

PrintArray(result);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите слово: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]} ");

    }
}

string[] FindTheWords(string[] array)
{
    int index = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
            index++;
        }
    }
    return result;
}