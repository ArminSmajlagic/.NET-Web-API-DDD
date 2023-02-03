using Domain.Models.Common;

namespace Domain.Services.Contracts.Common
{
    public interface IBaseService
    {
        List<BaseEntity> GetAll();

        BaseEntity GetByID(int id);

        int Insert(BaseEntity entity);

        int Update(BaseEntity entity);

        int Delete(int id);
    }
}