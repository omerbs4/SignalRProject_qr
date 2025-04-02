
namespace SignalR.DataAccessLayer.Repo
{
    public class SignalRDbContext
    {
        internal void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        internal T Find<T>(int id)
        {
            throw new NotImplementedException();
        }

        internal void Remove<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Set<T>()
        {
            throw new NotImplementedException();
        }
    }
}