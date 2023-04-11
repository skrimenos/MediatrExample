using MediatR;
using System.Xml.Linq;

namespace MediatrExample.Med.Queries
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            //use repository
            var data = new List<GetProductViewModel>()
            {
                new GetProductViewModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                },
                new GetProductViewModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Paper"
                },          
                new GetProductViewModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Pen"
                }
            };
            
            return Task.FromResult(data);
        }
    }
}
