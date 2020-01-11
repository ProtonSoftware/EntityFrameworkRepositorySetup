using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public interface IBaseRepository<TypeOfEntity, TypeOfId> where TypeOfEntity : BaseEntity<TypeOfId>
    {
        bool Add(TypeOfEntity entity, bool saveChanges = true);
        Task<bool> AddAsync(TypeOfEntity entity, bool saveChanges = true);
        bool Update(TypeOfEntity entity, bool saveChanges = true);
        Task<bool> UpdateAsync(TypeOfEntity entity, bool saveChanges = true);
        bool Delete(TypeOfEntity entity, bool saveChanges = true);
        Task<bool> DeleteAsync(TypeOfEntity entity, bool saveChanges = true);
        TypeOfEntity GetById(TypeOfId id);
        Task<TypeOfEntity> GetByIdAsync(TypeOfId id);
        List<TypeOfEntity> GetAll();
        Task<List<TypeOfEntity>> GetAllAsync();
    }
}