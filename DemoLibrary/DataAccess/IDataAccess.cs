using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel GetPersonById(int id);
        PersonModel InsertPerson(string firstName, string lastName);
    }
}