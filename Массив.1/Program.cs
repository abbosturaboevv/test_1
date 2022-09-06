
Console.WriteLine("Ввидете число ");
int num_user = int.Parse(Console.ReadLine()); // Convert.ToInt32() = int.Parse()
int[] number = new int[num_user];
for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(1, 10);
}
Console.WriteLine(String.Join(" ", number));

MultipleNumberArray(number,4);
MultipleNumberArray(number,5);
MultipleNumberArray(number,6);
MultipleNumberArray(number,7);

void MultipleNumberArray(int[] array, int multiple)

{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j] % multiple == 0)
        {
            Console.Write(array[j] + " ");
            count++;
        }
    }
    Console.WriteLine("Количество числе кратная " + multiple + " = " + count);
}
