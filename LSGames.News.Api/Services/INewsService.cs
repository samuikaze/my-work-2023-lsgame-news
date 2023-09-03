using LSGames.News.Api.Models.ServiceModels;

namespace LSGames.News.Api.Services
{
    public interface INewsService
    {
        /// <summary>
        /// 取得最新消息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<GetNewsResponseServiceModel> GetNewsList(GetNewsRequestServiceModel request);

        /// <summary>
        /// 取得所有最新消息種類
        /// </summary>
        /// <returns></returns>
        public Task<List<NewsTypeServiceModel>> GetNewsTypes();

        /// <summary>
        /// 依據最新消息 PK 取得最新消息
        /// </summary>
        /// <param name="newsId">最新消息 PK</param>
        /// <returns></returns>
        public Task<NewsServiceModel> GetNews(int newsId);

        /// <summary>
        /// 新增消息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<int> CreateNews(NewsServiceModel request);

        /// <summary>
        /// 更新消息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<int> UpdateNews(NewsServiceModel request);

        /// <summary>
        /// 刪除消息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<int> DeleteNews(NewsServiceModel request);
    }
}
