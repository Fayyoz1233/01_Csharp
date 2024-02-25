//вывести чётные числа на экран

//int n = 10;(2ой вариант)
int[] array = { 12, 5, 4, 7, 6, 35, 2, 3, 8, 5 };
int i = 0;

//while (i < n) (2ой вариант, см выше)
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
