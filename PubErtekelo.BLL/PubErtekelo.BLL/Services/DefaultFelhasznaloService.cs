using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PubErtekelo.BLL.Services
{
    class DefaultFelhasznaloService : IFelhasznaloService
    {
        private readonly pubertekeloDbContext _dbContextt;
        public async Task<ItemsViewModel<FelhasznaloListViewModel>> ListAsync(PagedFilter filter, CancellationToken cancellationToken)
        {
            if (filter is null)
            {
                throw new NotImplementedException();
            }
        }
    }
}
