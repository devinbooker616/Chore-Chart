using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Entities;
using BaseCamp.Chores.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Repository
{
    public class PersonRepository
    {
        private readonly ChoreDbContext _context;
        public PersonRepository(ChoreDbContext context)
        {
            this._context = context;
        }

        public Person CreatePerson(CreatePerson newPerson)
        {
            var person = new Person()
            {
                Id = Guid.NewGuid(),
                Name = newPerson.Name,
            };

            this._context.Person.Add(person);
            this._context.SaveChanges();

            return person;
        }
    }
}
