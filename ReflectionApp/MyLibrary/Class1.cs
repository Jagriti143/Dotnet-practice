using System;
using System.Diagnostics;

namespace MyReflectionDLL
{
    public interface I1
    {
        void m1();
        void m2();
    }
     public interface I2
    {
        void m3();
    }
     public interface I3
    {
        void m4();
    }

    public class A : I1,I2,I3
    {
        public void m1()
        {
            Console.WriteLine("m1 created successfully");
        }

        public void m2()
        {
            Console.WriteLine("m2 created successfully");
        }
        public void m3()
        {
            Console.WriteLine("m3 created successfully");
        }
        public void m4()
        {
            Console.WriteLine("m4 created successfully");
        }
    }
    public class B : A
    {
        public void m5()
        {
            Console.WriteLine("m5 created successfully");
        }
    }
}
