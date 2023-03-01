Console.Write("Первое число: ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int num_2 = int.Parse(Console.ReadLine());
if (num_2 * num_2 == num_1)
{
    Console.Write($"Число {num_1} является квадратом числа {num_2}.");
}
else
{
    Console.Write($"Число {num_1} НЕ является квадратом числа {num_2}.");    
}
