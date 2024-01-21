using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string videoUrl1 = "https://www.youtube.com/watch?v=tUjIwYeVlQc";
            string path = "C:\\Users\\Ghosman";

            Receiver receiver = new Receiver();
            Sender sender = new Sender();
            ConcreteCommand concreteCommand = new ConcreteCommand(receiver);
            sender.SetCommand(concreteCommand);
            sender.Info(videoUrl1);
            sender.Start(videoUrl1, path);
        }
    }
}