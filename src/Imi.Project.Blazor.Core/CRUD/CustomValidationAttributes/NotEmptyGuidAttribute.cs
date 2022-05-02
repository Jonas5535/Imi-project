using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.CustomValidationAttributes
{
	public class NotEmptyGuidAttribute : ValidationAttribute
	{
		public NotEmptyGuidAttribute()
		{
		}

		public override bool IsValid(object value)
		{
			Guid guid = (Guid)value;

			if (guid == Guid.Empty)
			{
				return false;
			}
			return true;
		}
	}
}
