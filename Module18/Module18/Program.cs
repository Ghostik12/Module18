using System;

namespace Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();
        }
    }
}