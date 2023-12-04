using System.Threading.Channels;

namespace maxNumber_02
{
    internal class maxNumber_02
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 3 digits: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            
            Console.WriteLine(maxNumber(first, second, third));
        }

        static int maxNumber(int a, int b, int c)
        {
            int currentMax = a;

            if (b > currentMax)
            {
                currentMax = b;
            }
            if (c > currentMax)
            {
                currentMax = c;
            }

            return currentMax;
        }
    }
}
