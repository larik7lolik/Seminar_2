// Задача 15: Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Ввести число: ");
int num = int.Parse(Console.ReadLine());
if(num % 7 ==0 && num % 23 == 0)
{
    Console.WriteLine("Число " + num + " кратно 7 и 23");
    return;
}
else
{
   Console.WriteLine("Число " + num + " Не кратно 7 и 23");
}
