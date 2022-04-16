using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handler.Insert
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, int>
    {
        private readonly IDataAccess _data;
        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<int> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            var insert =  _data.InsertPerson(request.Firstname, request.Lastname);

            return Task.FromResult(insert.Id);
        }
    }
}
