Console.WriteLine("Введите первое число: ");
 int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
 
if(a > b)

Console.WriteLine("Первое число больше второго");

else if (a < b)

Console.WriteLine("Первое число меньше второго");

else

Console.WriteLine("Оба числа равны");

//Console.WriteLine("Введите первое число: ");

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
 if (x > y && x > z)
                    Console.WriteLine("Nubmer Max = " + x); 
                else if (y > z)
                    Console.WriteLine("Number Max = " + y); 
                else
                    Console.WriteLine("Number Max = " + z); 

//Нахождение четного числа

Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine());

 //double(a%2);

if (a%2 == 0)
{
      Console.WriteLine("Число четное");
}
else
{
     Console.WriteLine("Число нечетное");
}
    
//Задача 4

Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
int count = 1;
while (count <=a)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count = count + 1;
    
}