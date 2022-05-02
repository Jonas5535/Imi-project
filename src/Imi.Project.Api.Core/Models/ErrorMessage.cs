using System.Net;

namespace Imi.Project.Api.Core.Models
{
    public class ErrorMessage
    {
        public HttpStatusCode ErrorType { get; set; }
        public string Message { get; set; }

        public static ErrorMessage BadRequestError(string message)
        {
            return new ErrorMessage
            {
                ErrorType = HttpStatusCode.BadRequest,
                Message = $"{message}",
            };
        }

        public static ErrorMessage NotFoundError(string message)
        {
            return new ErrorMessage
            {
                ErrorType = HttpStatusCode.NotFound,
                Message = $"{message}",
            };
        }

        public static ErrorMessage ConflictError(string message)
        {
            return new ErrorMessage
            {
                ErrorType = HttpStatusCode.Conflict,
                Message = $"{message}",
            };
        }

        public static ErrorMessage InternalServerError(string message)
        {
            return new ErrorMessage
            {
                ErrorType = HttpStatusCode.InternalServerError,
                Message = $"{message}",
            };
        }

        public static ErrorMessage Forbidden(string message)
        {
            return new ErrorMessage
            {
                ErrorType = HttpStatusCode.Forbidden,
                Message = $"{message}",
            };
        }
    }
}
