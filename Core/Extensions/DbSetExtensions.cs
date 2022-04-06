using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace MusicLibrary.DataAccess.Extensions
{
    public static class DbSetExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class, IEntity, new()
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
