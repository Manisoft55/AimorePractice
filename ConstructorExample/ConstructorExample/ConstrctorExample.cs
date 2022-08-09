using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class ConstrctorExample
    {
        internal string name;
        internal ConstrctorExample(string inputName)
        {
            this.name = inputName;
        }

        internal string ReturnName()
        {
            return this.name;
        }
    }

    internal class PrivateConstrctorExample
    {
        private PrivateConstrctorExample()
        {

        }
    }

    internal class StaticConstructorClass
    {
        static StaticConstructorClass()
        {
            Console.WriteLine("Static Constrcutor");
        }

        internal StaticConstructorClass()
        {
            Console.WriteLine("Default Constructor");
        }

        internal StaticConstructorClass(string name)
        {
            Console.WriteLine("Parameterized constructor : " + name);
        }
    }

    internal class CopyConstructor
    {
        internal string name;
        internal string age;
        internal CopyConstructor(string name, string age)
        {
            this.name = name;
            this.age = age;
        }
        internal CopyConstructor(CopyConstructor copy)
        {
            this.name = copy.name;
            this.age = copy.age;
        }
    }
}
