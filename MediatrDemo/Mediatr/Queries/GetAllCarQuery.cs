using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrDemo.Mediatr.Queries
{
    public class GetAllCarQuery : IRequest<List<GetCarByIdViewModel>>
    {
        

    }


    public class GetAllCarQueryHandler : IRequestHandler<GetAllCarQuery, List<GetCarByIdViewModel>>
    {
        public Task<List<GetCarByIdViewModel>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
        {
            var model = new GetCarByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Mercedes"
            };

            var model2 = new GetCarByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Mercedes"
            };

            return Task.FromResult(new List<GetCarByIdViewModel>() {model,model2 });
        }
    }
}
