using Microsoft.AspNetCore.Builder;

namespace Middleware
{
    /// <summary>
    /// Exception handler middleware extention class.
    /// </summary>
    public static class ExceptionHandlerMiddlewareExtention
    {
        /// <summary>
        /// Register exception handler middleware.
        /// </summary>
        public static void UseExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
