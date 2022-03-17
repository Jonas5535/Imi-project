using Imi.Project.Api.Core.Models;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        private List<ErrorMessage> ErrorMessages { get; set; }
        private bool _isSucces => ErrorMessages is null || ErrorMessages?.Count <= 0;

        public IEnumerable<ErrorMessage> GetErrors()
        {
            return ErrorMessages;
        }

        public void AddError(ErrorMessage error)
        {
            if (ErrorMessages is null)
            {
                ErrorMessages = new List<ErrorMessage>();
            }
            ErrorMessages.Add(error);
        }

        public void AddBadRequest(string message)
        {
            AddError(ErrorMessage.BadRequestError(message));
        }

        public void AddNotFound(string message)
        {
            AddError(ErrorMessage.NotFoundError(message));
        }

        public void AddConflict(string message)
        {
            AddError(ErrorMessage.ConflictError(message));
        }

        public void AddInternalServerError(string message)
        {
            AddError(ErrorMessage.ConflictError(message));
        }

        public void AddForbidden(string message)
        {
            AddError(ErrorMessage.Forbidden(message));
        }

        public bool IsSucces()
        {
            return _isSucces;
        }
    }
}
