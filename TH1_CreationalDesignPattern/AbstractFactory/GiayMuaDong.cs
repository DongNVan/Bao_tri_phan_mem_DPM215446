using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class GiayMuaDong : Giay
    {
        public override string getName()
        {
            return "Giay giu am";
        }

        public override string getModel()
        {
            return "Model Giay giu am";
        }

    }
}
