using Microsoft.AspNetCore.Mvc;

namespace Dapr.SubscribeApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{

	[Topic("pubsub", "newPub")]
	[HttpPost]
	public void ByCode(int id)
	{
		Console.WriteLine("Subscriber by code received : " + id);
	}
}
