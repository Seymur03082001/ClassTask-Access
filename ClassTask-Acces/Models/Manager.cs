﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Acces.Models
{
    internal class Manager
    {
        public Employee GetPromotion(Employee employee)
        {
            employee.Salary = 100;
            return Employee();
        }
    }
}
