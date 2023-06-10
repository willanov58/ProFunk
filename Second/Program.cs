void Sum(int n)
{
    int sum=0;
   int count=0;
   int temp=n;
    while (temp!=0)
    {
        temp=temp/10;
        count+=1;
    }
    for (int i=0;i<count;i++)
    {
        sum+=n%10;
        n=n/10;
    }
    System.Console.WriteLine(sum);

}
Console.Clear();
System.Console.Write("Введите число N => ");
int N =Convert.ToInt32(Console.ReadLine());
Sum(N);