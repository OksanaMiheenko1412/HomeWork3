// task19

Console.Clear();
int n = new Random().Next(10000, 99999); // [10000, 99999]
Console.WriteLine($"Случайное число: {n}");
int n2 = n / 1000; // первые две цифры
int n4 = n % 100; // последние две цифры
if(n2 == n4)
    Console.Write("yes");
else
    Console.Write("no");    