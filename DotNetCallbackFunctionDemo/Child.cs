using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCallbackFunctionDemo
{
    public class Child
    {
        public void NormalFunction()
        {
            Console.WriteLine("Normal function called");
        }

        public void CallbackFunction()
        {
            Console.WriteLine("Callback function called");
        }
    }
}
