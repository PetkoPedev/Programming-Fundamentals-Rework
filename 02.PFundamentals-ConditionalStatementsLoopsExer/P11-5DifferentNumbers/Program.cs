using System;

namespace P11_5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;

            var isValid = b - a >= 4;

            if (isValid)
            {
                for (n1 = a; n1 <= b; n1++)
                {
                    for (n2 = n1 + 1; n2 <= b; n2++)
                    {
                        for (n3 = n2 + 1; n3 <= b; n3++)
                        {
                            for (n4 = n3 + 1; n4 <= b; n4++)
                            {
                                for (n5 = n4 + 1; n5 <= b; n5++)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", n1, n2, n3, n4, n5);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
