void SecondArray(string[] nameTrue, string[] arrayTemp)
{
    int count = 0;
    for (int i = 0; i < nameTrue.Length; i++)
    {
    if(nameTrue[i].Length <= 3)
        {
        arrayTemp[count] = nameTrue[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] name = { "Tom", "Sam", "Bob", "Mabel", "Dipper", "Stanley" };
string[] nameTrue = new string[name.Length];
Console.WriteLine();
SecondArray(name, nameTrue);
PrintArray(nameTrue);