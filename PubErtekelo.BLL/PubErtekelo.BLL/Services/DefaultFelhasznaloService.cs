using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
using PubErtekelo.DAL;

namespace PubErtekelo.BLL.Services
{
    public class DefaultFelhasznaloService : IFelhasznaloService
    {
        private readonly PubErtekeloDbContext _dbContext;
        public DefaultFelhasznaloService(PubErtekeloDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ItemsViewModel<FelhasznaloListViewModel>> ListAsync(PagedFilter
       filter, CancellationToken cancellationToken)
        {
            if (filter is null)
            {
                throw new ArgumentNullException(nameof(filter));
            }
            var totalCount = await
           _dbContext.Felhasznalok.CountAsync(cancellationToken);
            var felhasznalok = await _dbContext.Felhasznalok
                .Skip(filter.Skip)
                .Take(filter.Take)
                .Select(x => new FelhasznaloListViewModel
                {
                    Id = x.Id,
                    Felhasznalonev = x.Felhasznalonev,
                    Email = x.Email,
                    Jelszo = x.Jelszo
                })
                .ToListAsync(cancellationToken);
            return new ItemsViewModel<FelhasznaloListViewModel>
            {
                Items = felhasznalok,
                TotalCount = totalCount
            };
        }
    }
}
