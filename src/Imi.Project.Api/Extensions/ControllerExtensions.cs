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
        /// <returns></returns>
        public static IActionResult HandleErrors(this ControllerBase controller, IEnumerable<ErrorMessage> errors)
        {
            if (errors.Count() > 0)
            {
                ErrorMessage errorMessage = errors.First();
                switch (errorMessage.ErrorType)
                {
                    case System.Net.HttpStatusCode.BadRequest:
                        return controller.BadRequest(errorMessage.Message);
                    case System.Net.HttpStatusCode.NotFound:
                        return controller.NotFound(errorMessage.Message);
                    case System.Net.HttpStatusCode.Conflict:
                        return controller.Conflict(errorMessage.Message);
                    case System.Net.HttpStatusCode.Forbidden:
                        return controller.Forbid(errorMessage.Message);
                    default:
                        return controller.StatusCode((int)errorMessage.ErrorType, errorMessage.Message);
                }
            }
            else
            {
                return controller.StatusCode(500, "The server detected no errors in this request but mistakenly handled it as one.");
            }
        }
    }
}
