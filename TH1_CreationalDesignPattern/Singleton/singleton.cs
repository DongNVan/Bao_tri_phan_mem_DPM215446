using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class singleton
    {
        private static singleton _instance;

        protected singleton()
        {
        }

        public static singleton Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new singleton();
            }

            return _instance;
        }
    }
}
