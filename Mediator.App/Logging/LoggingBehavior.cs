using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.App.Logging
{
    public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine($"Start logging {typeof(TRequest).Name}");
            var response = await next();
            Console.WriteLine($"Finished logging {typeof(TRequest).Name}");
            return response;
        }
    }
}
