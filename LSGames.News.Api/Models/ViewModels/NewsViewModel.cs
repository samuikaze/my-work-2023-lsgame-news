namespace LSGames.News.Api.Models.ViewModels
{
    public class NewsViewModel
    {
        /// <summary>
        /// 最新消息 PK
        /// </summary>
        public long NewsId { get; set; }

        /// <summary>
        /// 最新消息種類 PK
        /// </summary>
        public long NewsTypeId { get; set; }

        /// <summary>
        /// 最新消息標題
        /// </summary>
        public string NewsTitle { get; set; } = null!;

        /// <summary>
        /// 最新消息內容
        /// </summary>
        public string NewsContent { get; set; } = null!;

        /// <summary>
        /// 建立帳號 PK
        /// </summary>
        public long? CreatedUserId { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 最後更新帳號 PK
        /// </summary>
        public long? UpdatedUserId { get; set; }

        /// <summary>
        /// 最後更新時間
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 刪除帳號 PK
        /// </summary>
        public long? DeletedUserId { get; set; }

        /// <summary>
        /// 刪除時間
        /// </summary>
        public DateTime? DeletedAt { get; set; }
    }
}
