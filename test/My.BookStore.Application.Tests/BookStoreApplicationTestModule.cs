using Volo.Abp.Modularity;

namespace My.BookStore;

[DependsOn(
    typeof(BookStoreApplicationModule),
    typeof(BookStoreDomainTestModule)
)]
public class BookStoreApplicationTestModule : AbpModule
{

}
