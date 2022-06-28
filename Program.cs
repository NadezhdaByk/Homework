// определить макс и мин из двух чисел
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.Write("числа равны");
}

if (num1 > num2) 
{
    Console.Write("максимальное число ");
    Console.WriteLine(num1);
    Console.Write("минимальное число ");
    Console.WriteLine(num2);
}
if (num1 < num2) 
{
    Console.Write("максимальное число ");
    Console.WriteLine(num1);
    Console.Write("минимальное число ");
    Console.WriteLine(num2);
}