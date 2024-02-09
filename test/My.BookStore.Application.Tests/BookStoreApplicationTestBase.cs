using Volo.Abp.Modularity;

namespace My.BookStore;

public abstract class BookStoreApplicationTestBase<TStartupModule> : BookStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
