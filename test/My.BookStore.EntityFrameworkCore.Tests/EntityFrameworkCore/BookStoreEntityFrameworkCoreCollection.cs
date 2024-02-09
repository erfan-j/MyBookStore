using Xunit;

namespace My.BookStore.EntityFrameworkCore;

[CollectionDefinition(BookStoreTestConsts.CollectionDefinitionName)]
public class BookStoreEntityFrameworkCoreCollection : ICollectionFixture<BookStoreEntityFrameworkCoreFixture>
{

}
