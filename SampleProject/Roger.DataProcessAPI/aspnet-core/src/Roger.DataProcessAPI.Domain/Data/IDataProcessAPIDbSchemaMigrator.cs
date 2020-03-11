using System.Threading.Tasks;

namespace Roger.DataProcessAPI.Data
{
    public interface IDataProcessAPIDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
