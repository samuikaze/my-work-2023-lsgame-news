using LSGames.News.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGames.News.Repository.Repositories
{
    public interface INewsRepository : IGenericRepository<Models.News>
    {
        /// <summary>
        /// 取得最新消息
        /// </summary>
        /// <param name="skip">跳過筆數</param>
        /// <param name="rowPerPage">每頁筆數</param>
        /// <returns></returns>
        public Task<List<Models.News>> GetNewsList(int skip, int rowPerPage);

        /// <summary>
        /// 取得最新消息總筆數
        /// </summary>
        /// <returns></returns>
        public Task<int> GetTotalNewsRows();

        /// <summary>
        /// 依據最新消息 PK 取得最新消息
        /// </summary>
        /// <param name="newsId">最新消息 PK</param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public Task<Models.News> GetNews(long newsId);
    }
}
