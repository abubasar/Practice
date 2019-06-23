using System;

namespace ConstructorChaining
{
    class A
    {
        public A()
        {
            Console.WriteLine("A's Constructor with o params");
        }
        public A(int x)
        {
            Console.WriteLine("A's Constructor with 1 parameters");
        }
    }

    class B:A
    {
        public B():base(5)
        {
            Console.WriteLine("B's Constructor with 0 params");
        }
        public B(int x,int y)
        {
            Console.WriteLine("B's consrtructor with 2 parameters");
        }
    }

    class C:B
    {
        public C():base(2,4)
        {
            Console.WriteLine("C's Constructor with 0 params");
        }
        public C(int x)
        {
            Console.WriteLine("C's constructor with 1 params");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
   //         A a = new A();
         //   B b = new B();
            C c = new C(5);
            
            Console.ReadLine();
        }
    }
}
