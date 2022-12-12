// Переворот массива 

int [] nums = {1, 2, 3 ,4 ,5};

int length = nums.Length;
for (int i = length - 1; i >= 0; i--)
{
    Console.Write($"{nums[i]} ");
}

