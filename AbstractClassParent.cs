using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class AbstractClassParent
    {
        public void DoSomething()   //can be called by any child of this class
        {
            Console.WriteLine("In DoSomething() in " + this.GetType().ToString());
        }

        public virtual void DoSomethingVirtual()    //can be overwritten in each subclass
        {
            Console.WriteLine("In DoSomethingVirtual() in " + this.GetType().ToString());
        }
        public abstract void DoSomethingAbstract(); //must be declared individually in each subclass

    }
}
