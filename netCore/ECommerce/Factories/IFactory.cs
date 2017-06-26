using ECommerce.Models;
using System.Collections.Generic;
namespace ECommerce.Factory
{
    public interface IFactory<T> where T : BaseEntity
    {
    }
}
