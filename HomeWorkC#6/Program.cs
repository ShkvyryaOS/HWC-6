//Задача 1. Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

 int CountPositiveNumbers(int m)
 { int count=0;

    for (int i=1; i<=m; i++)
    { 
        Console.WriteLine($"Введите {i} число");
       int num=Convert.ToInt32(Console.ReadLine());
            if (num>0) 
            {count+=1;}
    }
    return count;
 }
 Console.WriteLine("Укажите количество чисел, которые введет пользователь, необходимое для подсчета в них положительных");
int size=Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Количество положительных чисел из введенных пользователем равно {CountPositiveNumbers(size)}");

*/


/*
// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint( double a1,  double c1,  double a2,  double c2)
{if (a1!=a2)
    {
    double x=Math.Round((c2-c1)/(a1-a2),2);
    double y=Math.Round((a1*(c2-c1)/(a1-a2)+c1),2);
    Console.WriteLine($"Прямые пересекаются в точке с координатами ({x};{y})");
    }
if (a1==a2 && c2!=c1)
    Console.WriteLine("Прямые не пересекаются");
if (a1==a2 && c2==c1)
    Console.WriteLine("Прямые совпадают");

}
Console.WriteLine("Введите параметры k1, b1  прямой вида y = k1 * x + b1");
Console.Write("k1=");
double k1=Convert.ToDouble(Console.ReadLine());
Console.Write("b1=");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите параметры k2, b2  прямой вида y = k2 * x + b2");
Console.Write("k2=");
double k2=Convert.ToDouble(Console.ReadLine());
Console.Write("b2=");
double b2=Convert.ToDouble(Console.ReadLine());
IntersectionPoint(k1,b1,k2,b2);
*/