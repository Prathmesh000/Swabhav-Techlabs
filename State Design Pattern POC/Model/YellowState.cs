using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Interface;

namespace StateDesignPattern.Model
{
    public class YellowState : IState
    {
        public void Handle(TrafficLightContext context)
        {
            Console.WriteLine("Traffic light is now Yellow. Switching to Red.");
            context.State = new RedState(); // Switch to Red state
        }
    }
}
