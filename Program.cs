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