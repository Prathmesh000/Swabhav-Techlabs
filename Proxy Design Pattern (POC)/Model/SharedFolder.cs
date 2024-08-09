using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDesignPattern2.GlobalInterface;

namespace ProxyDesignPattern2.Model
{
    internal class SharedFolder : ISharedFolder
    {
        public void ReadWriteOperation()
        {
            Console.WriteLine("This is Original Folder");
            Console.WriteLine("Perform Read Write Operation");
        }
    }
}
