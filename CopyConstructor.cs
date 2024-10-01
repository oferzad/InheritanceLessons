using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLessons
{
    internal class CopyConstructor
    {
    }

    class A
    {
        int a;
        public A(A a)
        {
            this.a = a.a;
        }
        public A(int a)
        {
            this.a = a;
        }
    }
    class B : A
    {
        int b;
        public B(B b):base(b)
        {
            this.b = b.b;
        }
        public B(int b, int a) : base(a)
        {
            this.b = b;
        }
    }
}
