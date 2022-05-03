using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.CustomValidationAttributes
{
	public class NotEmptyCollection : ValidationAttribute
	{
		public NotEmptyCollection()
		{
		}

		public override bool IsValid(object value)
		{
			ICollection<Guid> collection = (ICollection<Guid>)value;

			if (collection.Count == 0)
			{
				return false;
			}
			return true;
		}
	}
}
