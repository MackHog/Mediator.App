using MediatR;

namespace Mediator.App.Core
{
    public class GetQuery<T> : IRequest<T>
    {
        public int Id;
        public GetQuery(int id)
        {
            Id = id;
        }
    }

    public class DeleteCommand<T> : IRequest
    {

    }

    public class DeleteByIdCommand<T, ID> : IRequest
    {

    }
}