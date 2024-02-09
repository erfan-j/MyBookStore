using System;
using System.Collections.Generic;
using System.Text;
using My.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace My.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
