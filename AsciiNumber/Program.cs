

namespace AsciiNumber
{
    public class Program
    {
        public delegate void asciiCodeDelegate();
        public static asciiCodeDelegate AsciiCodedelegate = AsciiCode;
        static void AsciiCode()
        {
            int number = int.Parse(Console.ReadLine());
            string binaryCode = "";
            while (number > 0)
            {
                binaryCode = (number % 2) + binaryCode;
                number = number / 2;
            }
            Console.Write(binaryCode);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello,Ascii World!");
            AsciiCodedelegate();
            Console.ReadLine();
        }
    }
}
   