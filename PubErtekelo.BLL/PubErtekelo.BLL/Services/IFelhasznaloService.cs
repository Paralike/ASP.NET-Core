using System.Threading;
using System.Threading.Tasks;
using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
namespace TanulmanyiRendszer.BLL.Services
{
    public interface IFelhasznaloService
    {
        Task<ItemsViewModel<FelhasznaloListViewModel>> ListAsync(PagedFilter filter, CancellationToken cancellationToken);
    }
}
