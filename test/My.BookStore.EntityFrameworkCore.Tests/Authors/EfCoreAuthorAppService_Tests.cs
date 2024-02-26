using My.BookStore.EntityFrameworkCore;
using Xunit;

namespace My.BookStore.Authors;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
{

}