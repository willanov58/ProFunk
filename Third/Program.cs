void Massive(string[] massive)
{
if (massive.Length==8)
{
    Console.Write("[");
    for (int i=0;i<massive.Length;i++)
{
    if (Convert.ToInt32(massive[i])>=0 && i!=7)
    {
        Console.Write($"{massive[i]}, ");
    }
     if (Convert.ToInt32(i)==7)
    {
        Console.Write($"{massive[i]}");

    }

}
Console.Write("]");
}

}

Console.Clear();
Console.Write("Введите 8 элементов через пробел => ");
string[] mas = Console.ReadLine().Split(new Char[] { ' ' });
Massive(mas);