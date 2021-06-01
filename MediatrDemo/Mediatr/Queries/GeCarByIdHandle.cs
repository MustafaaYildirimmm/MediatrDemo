using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrDemo.Mediatr.Queries
{
    public class GeCarByIdHandle : IRequestHandler<GetCarQueryByIdQuery, GetCarByIdViewModel>
    {
        public Task<GetCarByIdViewModel> Handle(GetCarQueryByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetCarByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Volvo"
            };

            return Task.FromResult(viewModel);
            //get car from repository
        }
    }
}
