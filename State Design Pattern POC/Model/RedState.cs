using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Interface;

namespace StateDesignPattern.Model
{
    public class RedState : IState
    {
        public void Handle(TrafficLightContext context)
        {
            Console.WriteLine("Traffic light is now Red. Switching to Green.");
            context.State = new GreenState(); // Switch to Green state
        }
    }
}
