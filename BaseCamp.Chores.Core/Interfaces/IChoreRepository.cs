using BaseCamp.Chores.Core.DTOs;
using BaseCamp.Chores.Core.Entities;

namespace BaseCamp.Chores.Repository
{
    public interface IChoreRepository
    {
        Chore CreateChore(CreateChore newChore);
        void DeleteChore(Guid id);
        Chore GetChore(Guid id);

        List<Chore> GetChores();
    }
}