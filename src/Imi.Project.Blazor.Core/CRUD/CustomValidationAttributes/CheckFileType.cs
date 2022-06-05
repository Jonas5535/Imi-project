using Imi.Project.Blazor.Core.CRUD.Models.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.CustomValidationAttributes
{
    public class CheckFileType : ValidationAttribute
    {
        public CheckFileType()
        {
        }

        public override bool IsValid(object value)
        {
            ImageFile file = value as ImageFile;

            if (file != null)
            {
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/png")
                {
                    return true;
                }
                return false;
            }
            return true;
        }
    }
}
