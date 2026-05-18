using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ps_myfun;

public class Function1
{
    private readonly ILogger<Function1> _logger;

    public Function1(ILogger<Function1> logger)
    {
        _logger = logger;
    }

    [Function("FunFirst")]
    public IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route ="test/{a}")] HttpRequest req, string a)
    {
        _logger.LogInformation($"C# HTTP trigger function processed a request. We loggen {a}");
        return new OkObjectResult($"Welcome to Azure Functions! a={a}");
    }
}