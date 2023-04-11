using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductViewModel>>
    {
    }

}
