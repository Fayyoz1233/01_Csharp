int n = 10;
int[] arr = new int[n];
int i = 0;

//while (i < n) (ниже 2ой вариант)
while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(' '); (ниже сокращение)
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
