using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using MyLibraryApi.books;
using MyLibraryApi.LibraryTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApi.LibraryTask
{
    public class LibraryAppService : MyLibraryApiAppServiceBase, ILibraryAppService
    {
        private readonly IRepository<Book> _bookRepository;

        public LibraryAppService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ListResultDto<BooksListDto>> GetAll(GetAllBooksInput input)
        {
            var books = await _bookRepository
                .GetAll()
                .Include(b => b.DueDate)
                .WhereIf(input.State.HasValue, b => b.State == input.State)
                .OrderByDescending(b => b.CreationTime)
                .ToListAsync();

            return new ListResultDto<BooksListDto>(
                ObjectMapper.Map<List<BooksListDto>>(books)
            );
        }

        
    }
}
