using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ClassChild : ClassParent
    {
        public override void DoSomethingVirtual()   //overrides the defined method of parent
        {
            //Call method of parent object
            base.DoSomethingVirtual();

            //OR: override method
            //Console.WriteLine("In DoSomethingVirtual() in " + this.GetType().ToString());
        }
    }
}
