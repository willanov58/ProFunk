void count(string num)
{
    int k =0;
    char[]arr=new char [num.Length];
    for (int i=0;i<num.Length;i++)
    {
        arr[i]=num[i];
        Console.Write(arr[i]);
    }
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]!=Convert.ToChar(","))
        {
            k+=1;
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine(k);


}
Console.Clear();
Console.Write("Введите число N: ");
string N = Console.ReadLine();
double check = Convert.ToDouble(N);
count(N);