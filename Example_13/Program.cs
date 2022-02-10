// Задача 13: Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int numA = 4;
if(num % numA == 0)
{
    Console.WriteLine("Число кратно");
}
else 
{
   Console.WriteLine("Число равно " + num % numA);
}

