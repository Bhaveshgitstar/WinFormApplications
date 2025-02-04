using System;

namespace EventDelgateTry
{

    public delegate void MyDelegate1(int a, int b);

    //public delegate void MyDeleagte2();

    public class Class1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

    }
}
