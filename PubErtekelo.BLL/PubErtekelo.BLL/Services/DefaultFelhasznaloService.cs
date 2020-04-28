using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PubErtekelo.DAL;

namespace PubErtekelo.BLL.Services
{
    public class DefaultFelhasznaloService : IFelhasznaloService
    {
        private readonly PubErtekelo.DAL.PubErtekeloDbContext _dbContext;
        public DefaultFelhasznaloService(PubErtekeloDbContext dbContext) { _dbContext = dbContext; }
        public async Task<ItemsViewModel<FelhasznaloListViewModel>> ListAsync(PagedFilter filter, CancellationToken cancellationToken)
        {
            if (filter is null)
            {
                throw new NotImplementedException();
            }
        }
    }
}
