using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Shared.CustomValidationAttributes
{   //Werkt niet
    //TODO Hulp vragen aan lector
    public class LaterThanAttribute : ValidationAttribute
    {
        readonly DateTime _dateToCompare;

        public LaterThanAttribute(object givenDate)
        {
            _dateToCompare = (DateTime)givenDate;
        }

        public override bool IsValid(object value)
        {
            DateTime dt = (DateTime)value;

            if (dt > _dateToCompare)
            {
                return true;
            }
            return false;
        }
    }
}
