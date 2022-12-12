
// Перевод числа в двоичное =========================================================

// int a = 5;
// int b = 7;
// double x = Convert.ToDouble(b) / Convert.ToDouble(a); 
// Console.WriteLine(x);

// Двумерные массивы =========================================================

int [] nums = {1, 2 ,3 ,4 ,5 ,6, 7}; // Одномерны массив 

int [,] nums1 = {{1, 2, 3, 4}, {5, 6, 7, 8}, {1, 3, 5, 0}}; // Двумерный массив

int [,] nums2 = new int [3,4]; // Создаем двумерный массив без заполнения (по умолчанию тут нули). 

// 1 2 3 4 
// 5 6 7 8
// 9 0 3 4

Console.WriteLine();
for (int i = 0; i < nums1.GetLength(0); i++)
{
    for (int j = 0; j < nums1.GetLength(1); j++)
    {
        Console.Write($"{nums1[i,j]} ");
    }
    Console.WriteLine();
}
