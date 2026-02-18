namespace _03GlobalException.Exceptions
{
    using System.Text.Json;

    public class GlobalException
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalException> _logger;
        private readonly IWebHostEnvironment _env;

        public GlobalException(
            RequestDelegate next,
            ILogger<GlobalException> logger,
            IWebHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled Exception");

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.Redirect("/Error/500");
            }
        }
    }

}
