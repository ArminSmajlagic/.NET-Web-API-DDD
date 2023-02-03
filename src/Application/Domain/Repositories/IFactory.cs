using Domain.Models.Common;
using Domain.Repositories.Common;

namespace Domain.Repositories
{
    public interface IFactory
    {
        IBaseRepository GetRepository(string? repository = null);
    }
}
