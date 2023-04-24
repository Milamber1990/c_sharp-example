Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num % 2;

if(num1 == 0)
Console.Write("ДА");

if(num1 == 1)
Console.Write("НЕТ");