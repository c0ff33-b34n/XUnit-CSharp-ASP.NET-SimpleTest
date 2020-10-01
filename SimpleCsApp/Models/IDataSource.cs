using System.Collections.Generic;

namespace SimpleCsApp.Models
{
    public interface IDataSource
    {
        IEnumerable<Product> Products { get; }
    }
}