using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Shared.CustomValidationAttributes
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        public CurrentDateAttribute()
        {
        }

        public override bool IsValid(object value)
        {
            DateTime dt = (DateTime)value;
            if (dt > DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}
