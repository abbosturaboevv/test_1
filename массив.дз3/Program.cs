Console.Clear();
Console.WriteLine("Ввидите цифру, обозначающую день недели");
int dayOfWeek = int.Parse(Console.ReadLine());
if (dayOfWeek<8 && dayOfWeek>0)
{
    if(dayOfWeek==6 || dayOfWeek==7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будный");
    }
}
else
{
   Console.WriteLine("Число выходит за диапазон [1;7]");
}