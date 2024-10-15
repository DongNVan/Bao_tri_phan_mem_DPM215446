using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class GiayMuaHe : Giay
    {
        public override string getName()
        {
            return "Giay chong nang";
        }

        public override string getModel()
        {
            return "Model Giay chong nang";
        }

    }
}
