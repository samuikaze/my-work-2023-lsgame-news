using System;
using System.Collections.Generic;

namespace LSGames.News.Repository.Models;

/// <summary>
/// 最新消息種類
/// </summary>
public partial class NewsType
{
    /// <summary>
    /// 最新消息種類 PK
    /// </summary>
    public long NewsTypeId { get; set; }

    /// <summary>
    /// 最新消息種類名稱
    /// </summary>
    public string Name { get; set; } = null!;

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

    public virtual ICollection<News> News { get; set; } = new List<News>();
}
