Console.WriteLine("Введите число кратное 7 и 23 одновременно:");
int a = Convert.ToInt32(Console.ReadLine());

if (a%7==0 && a%23==0)
{
    Console.WriteLine("Условие выполнено!");
}
else
{
    Console.WriteLine("Введенное число не кратно одновременно 7 и 23 одновременно! Условие не выполнено!");
}