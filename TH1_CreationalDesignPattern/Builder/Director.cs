using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        public void Construct(builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
