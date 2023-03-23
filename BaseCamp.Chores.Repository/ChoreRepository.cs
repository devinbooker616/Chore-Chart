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
    public class ChoreRepository : IChoreRepository
    {
        private readonly ChoreDbContext _context;
        public ChoreRepository(ChoreDbContext context)
        {
            this._context = context;
        }

        public Chore CreateChore(CreateChore newChore)
        {
            var chore = new Chore()
            {
                Id = Guid.NewGuid(),
                Name = newChore.Name,
            };

            this._context.Chore.Add(chore);
            this._context.SaveChanges();

            return chore;
        }

        public List<Chore> GetChores()
        {
            return this._context.Chore.ToList();
        }

        public Chore GetChore(Guid id)
        {
            return this._context.Chore.FirstOrDefault(c => c.Id == id);
        }

        public void DeleteChore(Guid id)
        {
            var chore =  this._context.Chore.FirstOrDefault(c => c.Id == id);

            this._context.Remove(chore);

            this._context.SaveChanges();
        }

    }
}
