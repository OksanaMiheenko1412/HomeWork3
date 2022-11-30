// task23 на вход(число N), на выход(таблица кубов чисел от 1 до N
// пример: 3-> 1,8,27; 5-> 1, 8, 27,64, 125)

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.WriteLine(Math.Pow(i, 3));
