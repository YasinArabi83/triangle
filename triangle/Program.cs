//یاسین عربی
//دنباله مثلثاتی

int First;
int Second;
int Result = 0;
Console.Write("enter the first num: ");
First = int.Parse(Console.ReadLine());
Console.Write("enter the second num: ");
Second = int.Parse(Console.ReadLine());
for (int x = First; x <= Second; x++)

{
    Result = (x * (x + 1)) / 2;

    Console.WriteLine(Result);
}
