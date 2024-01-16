Console.WriteLine("Введите координату Х не равную нулю:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y не равную нулю:");
int y = Convert.ToInt32(Console.ReadLine());

if(x!=0&&y!=0){
if(x>0&&y>0)
{
    Console.WriteLine("1-я четверть координатной плоскости!");
}
else if(x<0&&y>0)
{
    Console.WriteLine("2-я четверть координатной плоскости!");

}
else if(x<0&&y<0)
{
    Console.WriteLine("3-я четверть координатной плоскости!");

}
else
{
    Console.WriteLine("4-я четверть координатной плоскости!");

}
}
else
{
    Console.WriteLine("X и Y не должны быть равны нулю");
}