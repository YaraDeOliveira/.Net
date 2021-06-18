﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionarios.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addicionalCharge)
            :base (name, hours, valuePerHour)
        {
            AdditionalCharge = addicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}
