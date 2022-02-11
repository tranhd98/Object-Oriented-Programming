using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(25, 25, 25);
            Ball ball1 = new Ball(color1, 9);
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine("Throw count of Ball 1 before popping: " + ball1.numberOfThrow());
            ball1.Pop();
            ball1.Throw();
            ball1.Throw();
            Console.WriteLine("Throw count of Ball 1 after popping: " + ball1.numberOfThrow());

        }
    }
}
