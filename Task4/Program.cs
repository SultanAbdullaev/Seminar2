Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int mod;
while(num!=0)
{
    mod=num%10;
    Console.Write(mod);
    num/=10;
    if (num==0)
    {
        Console.WriteLine("\n");
        break;
    }
    Console.Write(", ");
}