using Domain.Models.Common;

namespace Domain.Repositories.Common
{
    public interface IBaseRepository
    {
        List<BaseEntity> GetAll();

        BaseEntity GetByID(int id);

        int Insert(BaseEntity entity);

        int Update(BaseEntity entity);

        int Delete(int id);
    }
}