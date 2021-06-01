using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrDemo.Mediatr.Queries
{
    public class GetCarQueryByIdQuery : IRequest<GetCarByIdViewModel>
    {
        public Guid Id { get; set; }
    }
}
