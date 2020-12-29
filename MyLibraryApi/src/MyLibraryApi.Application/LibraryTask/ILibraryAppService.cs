using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyLibraryApi.books;
using MyLibraryApi.LibraryTask.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApi.LibraryTask
{
    public interface ILibraryAppService : IApplicationService
    {
        Task<ListResultDto<BooksListDto>> GetAll(GetAllBooksInput input);
    }
}
