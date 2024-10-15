using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal abstract class ThoiTrang
    {
        public abstract Ao createAo();

        public abstract Giay createGiay();
    }
}
