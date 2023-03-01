Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 10;
Console.Write($"Последняя цифра числа {a} - {b}");
