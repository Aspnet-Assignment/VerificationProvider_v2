using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace VerificationProvider_v2.Functions
{
    public class GenerateVerificationCodeUsingHttp
    {
        private readonly ILogger<GenerateVerificationCodeUsingHttp> _logger;

        public GenerateVerificationCodeUsingHttp(ILogger<GenerateVerificationCodeUsingHttp> logger)
        {
            _logger = logger;
        }

        [Function("GenerateVerificationCodeUsingHttp")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
