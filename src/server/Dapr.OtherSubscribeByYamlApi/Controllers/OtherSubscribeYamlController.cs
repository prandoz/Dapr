using Microsoft.AspNetCore.Mvc;

namespace Dapr.OtherSubscribeByYamlApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OtherSubscribeYamlController : ControllerBase
{
	[HttpPost]
	public void OtherByYaml(int id)
	{
		Console.WriteLine("Subscriber by code received : " + id);
	}
}
