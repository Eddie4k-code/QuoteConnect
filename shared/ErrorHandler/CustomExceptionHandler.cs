using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandler;


/* Handle Exceptions in a centralized way */

public class CustomExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {

        if (exception is not shared.CustomExceptions.CustomException customException)
        {
            // If the exception is not a CustomException, we can handle it as a generic exception

            var exceptionMessage = exception.Message;

            var problemDetailsGeneric = new ProblemDetails{
                Title = "An Error has occured",
                Detail = exceptionMessage
            };

            await httpContext.Response.WriteAsJsonAsync(problemDetailsGeneric, cancellationToken);

            return true;

        }

       
            var problemDetails = new ProblemDetails
            {
                Title = customException.Message,
                Status = customException.StatusCode
            };

            httpContext.Response.StatusCode = customException.StatusCode;
            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
            
        // Return true to indicate that the exception was handled
        return true;
    }
}