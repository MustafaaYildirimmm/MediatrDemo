using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrDemo.Mediatr.Commands
{
    public class CreateCarCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

    }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Guid>
    {
        public Task<Guid> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
            //repo aracılığı ile veri db'e göderilir veya
            //event bus kullanılıyorsa event bus'a gönderilir.
        }
    }
}
