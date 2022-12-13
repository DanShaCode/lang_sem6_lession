// Задать число N
// Вывести на экран 
// Если N = 7 , 0 1 1 2 3 5 8

Console.WriteLine();
Console.Write("Введите количество чисел Фибоначчи, которые вы хотите получить: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [] fibonacci = new int [N];

int a0 = 0;
int a1 = 1;

fibonacci[0] = a0;
fibonacci[1] = a1;

for (int i = 2; i < N; i++)
{
    if (i == 2)
    {
    int a = a0 + a1;
    fibonacci[i] = a;
    Console.Write($"{"Вывод:"} {a0} {a1} {fibonacci[i]} ");
    a0 = a1;
    a1 = a;
    }
    else
    {
    int a = a0 + a1;
    fibonacci[i] = a;
    Console.Write($"{fibonacci[i]} ");
    a0 = a1;
    a1 = a;
    }
}
Console.WriteLine();