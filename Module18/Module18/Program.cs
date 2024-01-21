using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
}