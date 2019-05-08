using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingPolygon
{
    partial class Program
    {

        public delegate void MyErrorDelegate();
        static void Main(string[] args)
        {
            Subscriber subs = new Subscriber();
            subs.Error(); //throws an error
            ErrorHandler(subs.ErrDel); //"Catches" an error

        }

        private static void ErrorHandler(Delegate errorDelegate)
        {
            Console.WriteLine("Catched the error");
        }
    }
}
