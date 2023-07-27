using MediatorProject.MediatorPattern.Results;
using MediatR;
using System.Collections.Generic;

namespace MediatorProject.MediatorPattern.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {

    }
}
