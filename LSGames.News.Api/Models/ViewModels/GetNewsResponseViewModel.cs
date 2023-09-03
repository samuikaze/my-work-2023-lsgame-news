using LSGames.News.Api.Models.ServiceModels;

namespace LSGames.News.Api.Models.ViewModels
{
    public class GetNewsResponseViewModel
    {
        /// <summary>
        /// 最新消息清單
        /// </summary>
        public List<NewsServiceModel> NewsList { get; set; }
        /// <summary>
        /// 總頁數
        /// </summary>
        public int TotalPages { get; set; }
    }
}
