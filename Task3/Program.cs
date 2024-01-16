
Console.WriteLine("Введите целое число от 10 до 99:");
int num = Convert.ToInt32(Console.ReadLine());
int dig1 = num/10;
int dig2 = num%10;

if (num > 10 && num < 99)
{
if (dig1>dig2)
{
    Console.WriteLine(dig1);
}
else if(dig1<dig2)
{
    Console.WriteLine(dig2);

}
else
{
        Console.WriteLine("Обе цифры одинаковые!");
}
}
else
{
    Console.WriteLine("Нужно вводить числа от 10 до 99!");
}