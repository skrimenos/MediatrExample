using MediatR;

namespace MediatrExample.Med.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            return Task.FromResult(Guid.NewGuid());

            //use repository
        }
    }
}
