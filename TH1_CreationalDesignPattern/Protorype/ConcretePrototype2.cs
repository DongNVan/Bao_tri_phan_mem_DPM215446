using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protorype
{
    internal class ConcretePrototype2:Prototypes
    {
        public ConcretePrototype2(string id) : base(id)
        {
        }
        // Returns a shallow copy
        public override Prototypes Clone()
        {
            return (Prototypes)this.MemberwiseClone();
        }
    }
}
