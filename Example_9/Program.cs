// Задача 9: Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int result = num % 10;
Console.WriteLine(result);
