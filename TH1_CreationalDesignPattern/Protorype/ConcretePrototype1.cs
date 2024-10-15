using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protorype
{
    internal class ConcretePrototype1:Prototypes
    {
        public ConcretePrototype1(string id) : base(id)
        {
        }
        
        public override Prototypes Clone()
        {
            return (Prototypes)this.MemberwiseClone();
        }
    }
}
