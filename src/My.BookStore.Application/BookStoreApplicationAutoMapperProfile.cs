using AutoMapper;
using My.BookStore.Books;

namespace My.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
