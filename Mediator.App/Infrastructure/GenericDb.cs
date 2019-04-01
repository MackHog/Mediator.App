using Mediator.App.Core;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.App.Infrastructure
{
    public class GenericDb<T, ID> :
        IRequestHandler<GetQuery<T>, T>,
        IRequestHandler<DeleteCommand<T>>,
        IRequestHandler<DeleteByIdCommand<T, ID>>
    {
        public virtual Task<T> Handle(GetQuery<T> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(DeleteCommand<T> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Unit> Handle(DeleteByIdCommand<T, ID> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
