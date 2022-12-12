Console.WriteLine();
Console.Write("Введите цифру 3: ");

int userData = Convert.ToInt32(Console.ReadLine());
if (userData < 3 | userData > 3) Console.WriteLine("Ошибка ввода. Введите цифру 3.");
else
{
int [] nums = new int [userData];

void FillArray (int [] num)
{
    int length = num.Length;
    int index = 0;
    for (index = 0; index < length; index++)
    {
        num[index] = new Random().Next(1,10);
    }
}

void PrintArray (int [] nummss)
{
    int leng = nummss.Length;
    int i = 0;
    Console.WriteLine();
    Console.Write("Сформированный массив из чисел: ");
    for (i = 0; i < leng; i++)
    {
        Console.Write($"{nummss[i]} ");
    }
    Console.WriteLine();
}

FillArray(nums);
PrintArray(nums);
Console.WriteLine();

string yes = "Да. Можно построить треугольник.";
string no = "Нет. Построить треугольник нельзя.";

if (nums[0] < nums[1] + nums[2]
 && nums[1] < nums[2] + nums[0]
 && nums[2] < nums[1] + nums[0])
{
    Console.WriteLine(yes);
}
else Console.WriteLine(no);
}