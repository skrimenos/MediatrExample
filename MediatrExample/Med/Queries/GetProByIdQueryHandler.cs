using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var model = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            return Task.FromResult(model); 

            //Need to use repository
        }
    }
}
