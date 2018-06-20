using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceDemo.Models
{
    public class Test
    {
        public void Test1(IInterface1 input)
        {
            input.MethodI();
        }

        public void ExecTest()
        {
            Test1(new ClassB());
            Test1(new ClassC());
            var probeerMaar = new IInterface1();
        }
    }
}