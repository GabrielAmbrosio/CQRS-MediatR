using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handler
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess _data;

        public GetPersonByIdHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPersonById(request.id));
        }
    }
}
