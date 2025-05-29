using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCallbackFunctionDemo
{
    public class Parent
    {
        public void MainFunction(Action callbackFunction = null)
        {
            Console.WriteLine("Main function called");

            if (callbackFunction != null)
            {
                callbackFunction();
            }
        }
    }
}
