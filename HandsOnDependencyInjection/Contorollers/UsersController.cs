using Microsoft.AspNetCore.Mvc;

namespace HandsOnDependencyInjection.Contorollers
{
	[Route("api/[controller]/[action]")]
	public class UsersController : ControllerBase
	{
		private readonly IMyService service;

		public UsersController(IMyService service)
		{
			this.service = service;
		}

		public IActionResult GetUserByIndex(int index)
		{
			try
			{
				return Ok(this.service.RetrieveUserByIndex(index));
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}