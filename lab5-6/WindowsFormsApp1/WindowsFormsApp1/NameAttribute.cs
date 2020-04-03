using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SemestrAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                int temp = (int)value;
                if (temp < 3 && temp > 0)
                    return true;
                else
                    this.ErrorMessage = "семестр должен быть в пределах от 1 до 2";
            }
            return false;
        }
    }
}
