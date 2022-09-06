
Console.WriteLine("Ввидете число ");
int num_user = int.Parse(Console.ReadLine()); // Convert.ToInt32() = int.Parse()
int[] number = new int[num_user];
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(-999,999); // -994 -141 -135
}
Console.WriteLine(String.Join(" ", number));

int min = number[0];
for (int i = 0; i < number.Length; i++)
{
    if(min > number[i])
    {
        min = number[i];
    }
    
}
