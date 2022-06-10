using Microsoft.AspNetCore.Mvc;

namespace Dapr.SubscribeApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{
	[HttpPost]
	public void ByYaml([FromBody] int id)
	{
		Console.WriteLine("Subscriber by yaml received : " + id);
	}

	[Topic("pubsub", "daprs")]
	[HttpPost]
	public void ByCode([FromBody] int id)
	{
		Console.WriteLine("Subscriber by code received : " + id);
	}
}
