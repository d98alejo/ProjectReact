using Microsoft.AspNetCore.Mvc;

namespace ProjectReact.Controllers
{
	[ApiController]
	[Route("api/[controller]")] //Esta ruta puede ser consumida por cualquier controlador que lo requiera, ya que esta global.
	public class BaseApiController:ControllerBase
	{
		

	}
}
