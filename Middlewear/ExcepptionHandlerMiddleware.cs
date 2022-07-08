using Microsoft.AspNetCore.Http;

namespace Middleware
{
    /// <summary>
    /// Exception handler middleware.
    /// </summary>
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// Creates ExceptionHandlerMiddleware object.
        /// </summary>
        /// <param name="next">RequestDelegate object.</param>
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Catches exceptions.
        /// </summary>
        /// <param name="context">HttpContext object.</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch(Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// Exception handler.
        /// </summary>
        /// <param name="context">HttpContext.</param>
        /// <param name="ex">Exception.</param>
        /// <returns>HttpContext with http response status code and exception description.</returns>
        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            if (ex is IndexOutOfRangeException)
            {
                context.Response.StatusCode = 404;
            }
            else
            {
                context.Response.StatusCode = 500;
            }
            
            return context.Response.WriteAsync(ex.Message);
        }
    }
}