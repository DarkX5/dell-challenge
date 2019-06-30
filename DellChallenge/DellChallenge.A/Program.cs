using System;

namespace DellChallenge.A
{
    class Program
    {
        static void Main(string[] args)
        {
            // State and explain console output order.
            new B();
/*
    Console Output:
    A.A()
    B.B()
    A.Age

    (1) new B (B : A) => trigger constructor for [class A] first => Output: "A.A()"
    (2) => afterwards the [class B] constructor is called => Output: "B.B()"
    (3) [class B] constructor calls the [class A].[Age] function => Output: "A.Age"
*/
            Console.ReadKey();            
        }
    }

    class A
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                Console.WriteLine("A.Age");
            }
        }


        public A()
        {
            Console.WriteLine("A.A()");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B.B()");
            Age = 0;
        }
    }
}
