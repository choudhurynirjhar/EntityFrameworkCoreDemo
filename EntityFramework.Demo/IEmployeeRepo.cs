using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Demo
{
    internal interface IEmployeeRepo
    {
        Employee Create(string firstName, 
            string lastName, 
            string address, 
            string homePhone, 
            string cellPhone);

        Employee Update(Employee employee);

        void Delete(Employee employee);
    }
}
