using Imi.Project.Api.Core.Constants;
using System.Net;

namespace Imi.Project.Api.Core.Models
{
	public class ErrorMessage
	{
		public HttpStatusCode ErrorType { get; set; }
		public string ErrorReason { get; set; }
		public string Message { get; set; }

		public static ErrorMessage BadRequestError(string message)
		{
			return new ErrorMessage
			{
				ErrorType = HttpStatusCode.BadRequest,
				ErrorReason = StatusConstants.BadRequest,
				Message = $"{message}",
			};
		}

		public static ErrorMessage NotFoundError(string message)
		{
			return new ErrorMessage
			{
				ErrorType = HttpStatusCode.NotFound,
				ErrorReason = StatusConstants.NotFound,
				Message = $"{message}",
			};
		}

		public static ErrorMessage ConflictError(string message)
		{
			return new ErrorMessage
			{
				ErrorType = HttpStatusCode.Conflict,
				ErrorReason = StatusConstants.Conflict,
				Message = $"{message}",
			};
		}

		public static ErrorMessage InternalServerError(string message)
		{
			return new ErrorMessage
			{
				ErrorType = HttpStatusCode.InternalServerError,
				ErrorReason = StatusConstants.InternalServerError,
				Message = $"{message}",
			};
		}

		public static ErrorMessage Forbidden(string message)
		{
			return new ErrorMessage
			{
				ErrorType = HttpStatusCode.Forbidden,
				ErrorReason = StatusConstants.Forbidden,
				Message = $"{message}",
			};
		}
	}
}
