// task19: на вход любое число на выход (является ли число палиндромом)

Console.Clear();

Console.WriteLine("Введите пятизнвчное число ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n;
int newNumber = 0, i = Convert.ToString(n).Length -1; // перевод числа в строку
// нахождение длины строки, т.е. количество символов  внутри строки
while(i >= 0)
{
    
        newNumber +=  newNumber + (n % 10 * Convert.ToInt32(Math.Pow(10, i))); 
        n = n / 10;
        i--;
}    
Console.WriteLine(newNumber == result);   
