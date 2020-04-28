using System.Threading;
using System.Threading.Tasks;
using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
using PubErtekelo.BLL.Dtos;

namespace PubErtekelo.BLL.Services
{
    public interface IFelhasznaloService
    {
        Task<ItemsViewModel<FelhasznaloListViewModel>> ListAsync(PagedFilter filter, CancellationToken cancellationToken);

        Task<FelhasznaloViewModel> FindByIdAsync(int id, CancellationToken cancellationToken); 
        Task<FelhasznaloViewModel> CreateAsync(FelhasznaloDto dto, CancellationToken cancellationToken); 
        Task UpdateAsync(int id, FelhasznaloDto dto, CancellationToken cancellationToken); 
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}
