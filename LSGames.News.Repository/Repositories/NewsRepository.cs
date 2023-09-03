using LSGames.News.Repository.DBContexts;
using LSGames.News.Repository.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGames.News.Repository.Repositories
{
    public class NewsRepository : GenericRepository<Models.News>, INewsRepository
    {
        private LsgamesNewsContext _context;
        public NewsRepository(LsgamesNewsContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// 取得最新消息
        /// </summary>
        /// <param name="skip">跳過筆數</param>
        /// <param name="rowPerPage">每頁筆數</param>
        /// <returns></returns>
        public async Task<List<Models.News>> GetNewsList(int skip, int rowPerPage)
        {
            return await _context.News
                .Where(news => news.DeletedAt == null)
                .Skip(skip)
                .Take(rowPerPage)
                .ToListAsync();
        }

        /// <summary>
        /// 取得最新消息總筆數
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetTotalNewsRows()
        {
            return await _context.News.CountAsync();
        }

        /// <summary>
        /// 依據最新消息 PK 取得最新消息
        /// </summary>
        /// <param name="newsId">最新消息 PK</param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public async Task<Models.News> GetNews(long newsId)
        {
            var news = await _context.News
                .Where(news => news.NewsId == newsId && news.DeletedAt == null)
                .FirstOrDefaultAsync();

            if (news == null)
            {
                throw new NullReferenceException("找不到該消息");
            }

            return news;
        }
    }
}
