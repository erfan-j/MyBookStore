using System.Threading.Tasks;

namespace My.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
