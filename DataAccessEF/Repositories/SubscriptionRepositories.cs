using DataAccessEF.Data;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories
{
    public class SubscriptionRepositories : GenericRepository<Subscription> , ISubscriptionRepository
    {
        public SubscriptionRepositories(asp_tablesContext dbContext) : base(dbContext)
        {
        }
  /*      public IEnumerable<Subscription> GetAll() => _dbContext.Subscriptions.ToList();

        public Subscription GetId(int id)
        {
            return _dbContext.Subscriptions.Find(id);
        }*/
    }
}
