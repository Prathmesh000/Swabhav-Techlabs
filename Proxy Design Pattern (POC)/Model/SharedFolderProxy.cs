using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyDesignPattern2.GlobalInterface;

namespace ProxyDesignPattern2.Model
{
    internal class SharedFolderProxy : ISharedFolder
    {
        SharedFolder folder;
        Employee employee;

        public SharedFolderProxy(Employee employee)
        {
            this.employee = employee;
        }

        public void ReadWriteOperation()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "DEVELOPER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder's ReadWriteOperations method");
                folder.ReadWriteOperation();

            }
            else
            {
                Console.WriteLine("You don't have permission to access this folder");
            }
        }
    }
}
