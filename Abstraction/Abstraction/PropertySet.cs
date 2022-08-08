using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class PropertySet
    {
        // Declaration 1
        public int Property { get; set; }

        // Declaration 2
        public int PropertyOne;

        // Declaration 3
        private int propertyTwo;
        public int PropertyTwo
        {
            get { return 20; }
        }

        public float PiValue
        {
            get { return 3.141f; }
        }


    }
}
