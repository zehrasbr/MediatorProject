using MediatorProject.MediatorPattern.Queries;
using MediatorProject.MediatorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MediatorProject.DAL;

namespace MediatorProject.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductUpdateByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIdQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIdQueryResult
            {
                Brand = values.Brand,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock,
            };
        }
    }
}
