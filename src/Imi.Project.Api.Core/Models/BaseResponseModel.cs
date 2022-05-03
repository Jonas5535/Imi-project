using Imi.Project.Api.Core.Dtos;

namespace Imi.Project.Api.Core.Models
{
	public class BaseResponseModel<T> where T : BaseDto
	{
		public bool IsSucces { get; set; }
		public string Status { get; set; }
		public string ErrorMessage { get; set; }
		public T Data { get; set; }
	}
}
