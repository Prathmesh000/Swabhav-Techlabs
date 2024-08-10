using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateDesignPattern.Model;

namespace StateDesignPattern.Interface
{
    public interface IState
    {
        void Handle(TrafficLightContext context);
    }

}
