using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
using PubErtekelo.DAL;
using PubErtekelo.BLL.Dtos;

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

        public async Task<FelhasznaloViewModel> CreateAsync(FelhasznaloDto dto, CancellationToken cancellationToken)
        {
            var felhasznalo = new DAL.Entities.Felhasznalo
            {
                Id = dto.Id,
                Felhasznalonev = dto.Felhasznalonev,
                Email = dto.Email,
                Jelszo = dto.Jelszo
            };
            _dbContext.Felhasznalok.Add(felhasznalo);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return await FindByIdAsync(felhasznalo.Id, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var szemeszter = _dbContext.Felhasznalok.Find(id);
            if (szemeszter == null)
            {
                return;
            }
            _dbContext.Felhasznalok.Remove(szemeszter);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<FelhasznaloViewModel> FindByIdAsync(int id, CancellationToken cancellationToken)
        {
            var felhasznalo = await _dbContext.Felhasznalok.FindAsync(id);
            if (felhasznalo == default)
            {
                return null;
            }
            return new FelhasznaloViewModel
            {
                Id = felhasznalo.Id,
                Felhasznalonev = felhasznalo.Felhasznalonev,
                Email = felhasznalo.Email,
                Jelszo = felhasznalo.Jelszo
            };
        }

        public async Task UpdateAsync(int id, FelhasznaloDto dto, CancellationToken cancellationToken)
        {
            var felhasznalo = _dbContext.Felhasznalok.Find(id);
            if (felhasznalo == null)
            {
                throw new Exception("Szemeszter nem található.");
            }
            felhasznalo.Id = dto.Id;
            felhasznalo.Felhasznalonev = dto.Felhasznalonev;
            felhasznalo.Email = dto.Email;
            felhasznalo.Jelszo = dto.Jelszo;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }        
}
