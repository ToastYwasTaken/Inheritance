using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            ClassParent object1 = new ClassParent();
            object1.DoSomething();
            object1.DoSomethingVirtual();

            #endregion

            #region Abstract Inheritance    //you cannot instantiate the abstract parent!
            //AbstractClassParent object2 = new AbstractClassChild();
            ////OR: AbstractClassChild object2 = new AbstractClassChild();
            //object2.DoSomething();
            //object2.DoSomethingAbstract();
            //object2.DoSomethingVirtual();
            #endregion



            Console.Read();
        }
    }
}
