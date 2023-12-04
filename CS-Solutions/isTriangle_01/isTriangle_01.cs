namespace isTriangle_01
{
    using System;
    internal class isTriangle_01
    {
        static void Main(string[] args)
        {
            if (isTirangle(3, 4, 5))
            {
                Console.WriteLine("There is a triangle\n");
            }
            else
            {
                Console.WriteLine("There is not a triangle\n");
            }
        }
        static bool isTirangle(int a, int b, int c)
        {
            if (a * a + b * b == c * c)
            {
                return true;
            }

            return false;
        }
    }
}
