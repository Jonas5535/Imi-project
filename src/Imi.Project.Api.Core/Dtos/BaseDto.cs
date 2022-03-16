using Imi.Project.Api.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Dtos
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        private List<ErrorMessage> ErrorMessages { get; set; }
    }
}
