
Console.WriteLine("Hello,Ascii World!");
int number=int.Parse(Console.ReadLine());
string binarycode = "";
while (number>0)
{
    binarycode = (number % 2) + binarycode;
    number=number/2;
}
Console.Write(binarycode);