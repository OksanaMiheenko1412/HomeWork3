// task19: на вход (пятизначное число) на выход (является ли число палиндромом)

Console.Clear();

Console.WriteLine("Введите пятизнвчное число ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a;
int newNumber = 0, i = Convert.ToString(a).Length -1;

while(i >0)
{
    newNumber += (a % 10 * Convert.ToInt32(Math.Pow(10, i)));
}
    
Console.WriteLine(newNumber);
Console.WriteLine(newNumber == a);   
