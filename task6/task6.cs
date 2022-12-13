// Задать массив
// На выводе показать его копию

int [] newArray = {4, 4, 8, 5, 6, 7, 8, 9, 123};

int [] copyArray = new int [newArray.Length];

int len = newArray.Length;
int i = 0;
int count = 0;


void PrintArray (int [] print)
{
    int length = print.Length;
    int index = 0;
    Console.Write("Заданный массив: ");
    for (index = 0; index < length; index++)
    {
        Console.Write($"{print[index]} ");
    }
}

void CopyArray(int [] copy)
{
for (i = 0; i < len; i++)
{
    copyArray[i] = newArray[0 + count];
    count++;
    Console.Write($"{copyArray[i]} ");
}
}

Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine();
Console.Write("Копия заданного массива: ");
CopyArray(newArray);
Console.WriteLine();