// Задача 9: Показать последнюю цифру трёхзначного числа
/*Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int result = num % 10;
Console.WriteLine(result);*/

int EndNumber(int number)
{
    int result = number % 10;
    return result;
}
Console.WriteLine( "Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра: " + EndNumber(num));