using Microsoft.AspNetCore.Mvc;

namespace Dapr.SubscribeYamlApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SubscribeYamlController : ControllerBase
{
	[HttpPost]
	public void ByYaml(int id)
	{
		Console.WriteLine("Subscriber by code received : " + id);
	}
}
