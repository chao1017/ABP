using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Roger.Book.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roger.Book.Books
{
    public interface IBookAppService : IApplicationService
    {
        Task<ListResultDto<BookInfo>> GetAll();

        Task<BookInfo> Create(CreateBookInput input);

        int Create2(ADto input);
    }
}