using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{

    public record InsertPersonCommand(string Firstname, string Lastname) : IRequest<int>;

    /*public class InsertPersonCommand : IRequest<PersonModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public InsertPersonCommand(PersonModel pm)
        {
            FirstName = pm.FirstName;
            LastName = pm.LastName;
        }
    }*/
}
