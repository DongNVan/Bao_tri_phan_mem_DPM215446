using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ThoiTrangMuaHe : ThoiTrang
    {
        public override Ao createAo()
        {
            return new AoMuaHe();
        }

        public override Giay createGiay()
        {
            return new GiayMuaHe();
        }
    }
}
