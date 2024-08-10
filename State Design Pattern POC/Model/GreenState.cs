using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Interface;

namespace StateDesignPattern.Model
{
    public class GreenState : IState
    {
        public void Handle(TrafficLightContext context)
        {
            Console.WriteLine("Traffic light is now Green. Switching to Yellow.");
            context.State = new YellowState(); // Switch to Yellow state
        }
    }
}
