﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ConcreteCreatorA:Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
