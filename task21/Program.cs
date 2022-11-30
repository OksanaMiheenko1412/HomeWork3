// Task21: на вход (координаты 2 точек), на выход (расстояние между ними в
// 3D пространстве, пример: А(3,6,8); В(2,1,-7), ->15,84 )
Console.Clear();
Console.Write("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
// Match - класс(объект),в котором  есть определенный метод;
// Sqrt - метод извлечения квадратного корня; 
// Pow - метод возведения в степень;
//  2 - степень, в которую возводим.
