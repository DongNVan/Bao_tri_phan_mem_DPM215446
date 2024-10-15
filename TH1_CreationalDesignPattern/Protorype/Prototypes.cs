using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protorype
{
    internal abstract class Prototypes
    {
        string id;
        // Constructor
        public Prototypes(string id)
        {
            this.id = id;
        }
        // Gets id
        public string Id
        {
            get { return id; }
        }
        public abstract Prototypes Clone();
    }
}
