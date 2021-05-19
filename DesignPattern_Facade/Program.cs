using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Facade
{
    public class Program
    {
        /*
            The Facade Design Pattern is used to hide the complexities of a system 
            and provides an interface to the client using which the client can access 
            the system.
        
            The Façade (usually a wrapper) sits on the top of a group of subsystems 
            and allows them to communicate in a unified manner.
        */

        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
