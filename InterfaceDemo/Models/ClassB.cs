﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceDemo.Models
{
    public class ClassB: ClassA, IInterface1
    {
        public void MethodI()
        {
            //Doet ook niets
        }

    }
}