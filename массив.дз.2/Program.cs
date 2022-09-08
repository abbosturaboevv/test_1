Console.Clear();
int Number = new Random().Next(0,9999);
Console.WriteLine(Number);
string dumbNaming = Convert.ToString(Number);
if (dumbNaming.Length>2)
{
   Console.WriteLine(dumbNaming[2] + " - наша третья цифра");
}
else
{
   Console.WriteLine("третьей цифры нет");
}