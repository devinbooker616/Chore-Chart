using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Core.Interfaces
{
    public interface IPersonRepository
    {
        Person CreatePerson(CreateChore newChore);
        void DeletePerson(Guid id);
        Person GetPerson(Guid id);
    }
}
