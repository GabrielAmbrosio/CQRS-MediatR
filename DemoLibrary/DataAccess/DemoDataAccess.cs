using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Gabriel", LastName = "Ambrosio" });
            people.Add(new PersonModel { Id = 2, FirstName = "Marcelo", LastName = "Godoy" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel personModel = new PersonModel { FirstName = firstName, LastName = lastName };
            personModel.Id = people.Max(p => p.Id) + 1;
            people.Add(personModel);
            return personModel;
        }
    }
}
