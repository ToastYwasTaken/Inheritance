using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AbstractClassChild : AbstractClassParent
    {
        public override void DoSomethingVirtual()   //overrides the defined method of parent
        {
            //Call method of parent object
            base.DoSomethingVirtual();

            //OR: override method
            //Console.WriteLine("In DoSomethingVirtual() in " + this.GetType().ToString());
        }
        public override void DoSomethingAbstract()  //overrides the empty method of parent
        {
            Console.WriteLine("In DoSomethingAbstract() in " + this.GetType().ToString());
        }

    }
}
