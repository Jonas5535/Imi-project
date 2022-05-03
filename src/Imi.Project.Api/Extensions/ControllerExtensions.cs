using Imi.Project.Api.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Extensions
{
	public static class ControllerExtensions
	{
		/// <summary>
		/// Throws the topmost error as a HttpResponse
		/// </summary>
		/// <param name="controller"></param>
		/// <param name="errors"></param>
		/// <returns>An IActionResult that contains the topmost error wrapped inside a BaseResponseModel</returns>
		public static IActionResult HandleErrors(this ControllerBase controller, IEnumerable<ErrorMessage> errors)
		{
			BaseResponseModel<object> model = new BaseResponseModel<object> { IsSucces = false }; //TODO Possible cause for errors when requesting on client side
			if (errors.Count() > 0)
			{
				ErrorMessage errorMessage = errors.First();
				model.Status = errorMessage.ErrorReason;
				model.ErrorMessage = errorMessage.Message;

				switch (errorMessage.ErrorType)
				{
					case System.Net.HttpStatusCode.BadRequest:
						return controller.BadRequest(model);
					case System.Net.HttpStatusCode.NotFound:
						return controller.NotFound(model);
					case System.Net.HttpStatusCode.Conflict:
						return controller.Conflict(model);
					//case System.Net.HttpStatusCode.Forbidden: //TODO Ask lector how to handle forbid
					//    return controller.Forbid(errorMessage.Message);
					default:
						return controller.StatusCode((int)errorMessage.ErrorType, model);
				}
			}
			else
			{
				model.Status = "Internal Server Error";
				model.ErrorMessage = "The server detected no errors in this request but mistakenly handled it as one.";
				return controller.StatusCode(500, model);
			}
		}
	}
}
