Console.WriteLine("num1: ");
string var1 = Console.ReadLine();
int var_num1 = int.Parse(var1);
Console.WriteLine("num2: ");
string var2 = Console.ReadLine();
int var_num2 = int.Parse(var2);
if (var_num1 == var_num2 * var_num2)
    Console.Write("Yes");
else    
    Console.Write("No");