using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace My.BookStore.Books;

public interface IBookAppService : ICrudAppService
    <   //Defines CRUD methods
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto
    > 
    //or you can inherite from this : IApplicationService
{
    Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();
}