﻿using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace Dapr.PublishApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublishController : ControllerBase
{
	private readonly DaprClient _daprClient;
	public PublishController(DaprClient daprClient)
	{
		_daprClient = daprClient;
	}

	[HttpPut("publish")]
	public async Task PublishAsync([FromBody] int id)
	{
		await _daprClient.PublishEventAsync("pubsub", "daprs", id);

		Console.WriteLine("Published id : " + id);
	}
}
