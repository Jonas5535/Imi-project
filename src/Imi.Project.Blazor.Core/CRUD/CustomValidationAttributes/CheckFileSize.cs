using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.CustomValidationAttributes
{
    public class CheckFileSize : ValidationAttribute
    {
        public CheckFileSize()
        {
        }

        public override bool IsValid(object value)
        {
            ImageFile file = value as ImageFile;

            if (file != null)
            {
                if (file.Size > 2000000)
                {
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
