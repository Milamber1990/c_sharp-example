 Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maximum = num1;

if(num2 > maximum) maximum = num2;
if(num3 > maximum) maximum = num3;

Console.Write(maximum);