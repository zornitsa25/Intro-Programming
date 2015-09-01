using System;

class Sunglasses
{
    static void FirstLastRow(int n)
    {
        int Ast = 2 * n;
        Console.Write(new string('*', Ast));
        Console.Write(new string(' ', n));
        Console.Write(new string('*',Ast));

        Console.WriteLine();
    }
    static void Middle(int n)
    {
        char ast = '*';
        for (int i = 0; i < n-2;i++)
        {
            Console.Write(ast);
            Console.Write(new string('/', 2 * n - 2));
            Console.Write(ast);
            if(i==(n-3)/2)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }
            Console.Write(ast);
            Console.Write(new string('/', 2 * n - 2));
            Console.Write(ast);
            Console.WriteLine();
        }
    }
    static void Main()
    {
        // n is an odd number
        int n = int.Parse(Console.ReadLine());
        FirstLastRow(n);
        Middle(n);
        FirstLastRow(n);
    }
}
