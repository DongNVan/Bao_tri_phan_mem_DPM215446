using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ThoiTrangMuaDong : ThoiTrang
    {
        public override Ao createAo()
        {
            return new AoMuaDong();
        }

        public override Giay createGiay()
        {
            return new GiayMuaDong();
        }
    }
}
