Console.WriteLine();
Console.Write("Введите число от 1 до 100: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 | num > 100) Console.WriteLine("Ошибка ввода. Введите число от 1 до 100");
else
{
int oper1 = num % 2;
int num1 = oper1;

int oper2 = (num/2) % 2;
int num2 = oper2;

int oper3 = (num/2/2) % 2;
int num3 = oper3;

int oper4 = (num/2/2/2) % 2;
int num4 = oper4;

int oper5 = (num/2/2/2/2) % 2;
int num5 = oper5;

int oper6 = (num/2/2/2/2/2) % 2;
int num6 = oper6;

int oper7 = (num/2/2/2/2/2/2) % 2;
int num7 = oper7;

int oper8 = (num/2/2/2/2/2/2/2) % 2;
int num8 = oper8;

Console.WriteLine();
Console.WriteLine($"{"Двоичное представление числа"} {num} {":"} {num8} {num7} {num6} {num5} {num4} {num3} {num2} {num1}");
}