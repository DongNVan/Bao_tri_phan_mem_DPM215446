using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AoMuaHe : Ao
    {
        public override string getName()
        {
            return "Ao chong nang";
        }

        public override string getModel()
        {
            return "Model Ao chong nang";
        }

    }
}
