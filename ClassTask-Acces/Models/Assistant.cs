using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Acces.Models
{
    internal class Assistant:Employee
    {
        public void GetFeedBack(Employee employee)
        {
            if(employee.IsSuccessfull == true)
            {
                GetFeedBack(employee) true;
            }
            return false;
        }
    }
}
