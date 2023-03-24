using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCamp.Chores.Core.Interfaces
{
    public interface IAssignedChoreRepository
    {
        AssignedChore CreateAssignedChore(CreateAssignedChore newAssignedChore);
        void DeleteAssignedChore(Guid id);
        AssignedChore GetAssignedChore(Guid id);
    }
}
