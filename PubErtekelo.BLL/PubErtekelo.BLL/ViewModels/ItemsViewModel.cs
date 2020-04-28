using System;
using System.Collections.Generic;
using System.Text;

namespace PubErtekelo.BLL.ViewModels
{
    public class ItemsViewModel<T> where T : class
    {
        public IEnumerable<T> Items { get; set; }
        
        public int TotalCount { get; set; }
    }
}
