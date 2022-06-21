using Microsoft.AspNetCore.Mvc;

namespace Dapr.OtherSubscribeApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OtherSubscribeController : ControllerBase
{
	[Topic("pubsub", "newPub")]
	[HttpPost]
	public void OtherByCode(int id)
	{
		Console.WriteLine("Subscriber by code received : " + id);
	}
}
