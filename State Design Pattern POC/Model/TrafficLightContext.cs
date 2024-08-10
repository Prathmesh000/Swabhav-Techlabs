using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Interface;

namespace StateDesignPattern.Model
{
    public class TrafficLightContext
    {
        public IState _state;

        public TrafficLightContext(IState state)
        {
            _state = state;
        }

        public IState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
