using MediatorProject.MediatorPattern.Results;
using MediatR;

namespace MediatorProject.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<GetProductUpdateByIdQueryResult>
    {
        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
