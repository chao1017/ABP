using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Roger.Book.Books.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roger.Book.Books
{
    public class BookAppService : BookAppServiceBase, IBookAppService
    {
        private readonly IRepository<BookInfo> _bookInfoRepository;

        public BookAppService(IRepository<BookInfo> bookInfoRepository)
        {
            _bookInfoRepository = bookInfoRepository;
        }

        /// <summary>
        /// 取得所有書籍資料
        /// </summary>
        /// <returns></returns>
        public async Task<ListResultDto<BookInfo>> GetAll()
        {
            var books = await _bookInfoRepository
                .GetAll()
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<BookInfo>(
                ObjectMapper.Map<List<BookInfo>>(books));
        }

        /// <summary>
        /// Add Books Info
        /// </summary>
        /// <param name="input"> </param>
        /// <returns> </returns>
        public async Task<BookInfo> Create(CreateBookInput input)
        {
            var book = ObjectMapper.Map<BookInfo>(input);
            await _bookInfoRepository.InsertAsync(book);

            return null;
        }

        public int Create2(ADto input)
        {
            return 0;
        }
    }
}