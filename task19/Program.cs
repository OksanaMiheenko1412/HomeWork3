// task19: на вход (пятизначное число) на выход (является ли число палиндромом)

Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1000 || a > 99999)
{
    Console.Write("Вы ошиблись! \nВведите пятизначное число");
    a = Convert.ToInt32(Console.ReadLine());
}   
int a1 =  a / 10000;
int a2 = (a / 1000) % 10;
int a4 = (a % 100) / 10;
int a5 = a % 10;

if ( a1 == a5 && a2 == a4)
    Console.WriteLine("yes");
else    
    Console.WriteLine("no");   