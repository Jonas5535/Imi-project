using Imi.Project.Api.Core.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Extensions
{
    public static class DtoValidations
    {
        /// <summary>
        /// Checks IsSucces property of every dto in a list of dtos
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsSucces(this IEnumerable<BaseDto> result)
        {
            return !(result?.Count() > 0 && !result.First().IsSucces());
        }
    }
}
