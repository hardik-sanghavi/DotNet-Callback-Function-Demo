// See https://aka.ms/new-console-template for more information
using DotNetCallbackFunctionDemo;

Console.WriteLine("Hello, World!");

Parent parent = new Parent();
// main function without any callback
parent.MainFunction();

Child child = new Child();
child.NormalFunction();

// main function with callback
parent.MainFunction(child.CallbackFunction);

Console.Read();

