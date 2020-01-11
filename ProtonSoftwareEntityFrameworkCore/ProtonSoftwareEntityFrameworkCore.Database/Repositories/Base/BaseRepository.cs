using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProtonSoftwareEntityFrameworkCore.Database
{
    public abstract class BaseRepository<TypeOfEntity, TypeOfId> : IBaseRepository<TypeOfEntity, TypeOfId> 
        where TypeOfEntity : BaseEntity<TypeOfId>
    {
        protected ApplicationDbContext Database;

        protected abstract DbSet<TypeOfEntity> DbSet { get; }

        public BaseRepository(ApplicationDbContext dbContext)
        {
            Database = dbContext;
        }

        public bool Add(TypeOfEntity entity, bool saveChanges = true)
        {
            try
            {
                DbSet.Add(entity);
                if (saveChanges)
                {
                    return Database.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public async Task<bool> AddAsync(TypeOfEntity entity, bool saveChanges = true)
        {
            try
            {
                DbSet.Add(entity);
                if (saveChanges)
                {
                    return await Database.SaveChangesAsync() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public bool Update(TypeOfEntity entity, bool saveChanges = true)
        {
            try
            {
                DbSet.Update(entity);
                if (saveChanges)
                {
                    return Database.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(TypeOfEntity entity, bool saveChanges = true)
        {
            try
            {
                DbSet.Update(entity);
                if (saveChanges)
                {
                    return await Database.SaveChangesAsync() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public bool Delete(TypeOfEntity entity, bool saveChanges = true)
        {
            try
            {
                DbSet.Remove(entity);
                if (saveChanges)
                {
                    return Database.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public async Task<bool> DeleteAsync(TypeOfEntity entity, bool saveChanges = true)
        {
            try
            {
                DbSet.Remove(entity);
                if (saveChanges)
                {
                    return await Database.SaveChangesAsync() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public TypeOfEntity GetById(TypeOfId id) => DbSet.Find(id);
        public async Task<TypeOfEntity> GetByIdAsync(TypeOfId id) => await DbSet.FindAsync(id);

        public List<TypeOfEntity> GetAll() => DbSet.ToList();
        public async Task<List<TypeOfEntity>> GetAllAsync() => await DbSet.ToListAsync();
    }
}
