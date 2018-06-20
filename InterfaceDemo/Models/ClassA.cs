using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceDemo.Models
{
    public abstract class ClassA
    {
        private string attr1;
        public string Attr1
        {
            get { return attr1; }
            set { attr1 = value; }
        }

        public void Method1()
        {
            //Doet niets
        }
    }
}