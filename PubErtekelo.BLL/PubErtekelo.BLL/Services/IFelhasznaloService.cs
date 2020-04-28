using System;
using System.Collections.Generic;
using System.Text;
using PubErtekelo.BLL.Filters;
using PubErtekelo.BLL.ViewModels;
using System.Threading;
using System.Threading.Tasks;

namespace PubErtekelo.BLL.Services
{
    public interface IFelhasznaloService
    {
        Task<ItemsViewModel<FelhasznaloListViewModel>> ListAsync(PagedFilter filter, CancellationToken cancellationToken);
    }
}
