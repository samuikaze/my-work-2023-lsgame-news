using System;
using System.Collections.Generic;
using LSGames.News.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace LSGames.News.Repository.DBContexts;

public partial class LsgamesNewsContext : DbContext
{
    public LsgamesNewsContext(DbContextOptions<LsgamesNewsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Models.News> News { get; set; }

    public virtual DbSet<NewsType> NewsTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Models.News>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PRIMARY");

            entity.ToTable("news", tb => tb.HasComment("最新消息"));

            entity.HasIndex(e => e.NewsTypeId, "FK_news_types_TO_news");

            entity.Property(e => e.NewsId)
                .HasComment("最新消息 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("news_id");
            entity.Property(e => e.CreatedAt)
                .HasComment("建立時間")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedUserId)
                .HasComment("建立帳號 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("created_user_id");
            entity.Property(e => e.DeletedAt)
                .HasComment("刪除時間")
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedUserId)
                .HasComment("刪除帳號 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("deleted_user_id");
            entity.Property(e => e.NewsContent)
                .HasMaxLength(1024)
                .HasComment("最新消息內容")
                .HasColumnName("news_content");
            entity.Property(e => e.NewsTitle)
                .HasMaxLength(20)
                .HasComment("最新消息標題")
                .HasColumnName("news_title");
            entity.Property(e => e.NewsTypeId)
                .HasComment("最新消息種類 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("news_type_id");
            entity.Property(e => e.UpdatedAt)
                .HasComment("最後更新時間")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedUserId)
                .HasComment("最後更新帳號 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("updated_user_id");

            entity.HasOne(d => d.NewsType).WithMany(p => p.News)
                .HasForeignKey(d => d.NewsTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_news_types_TO_news");
        });

        modelBuilder.Entity<NewsType>(entity =>
        {
            entity.HasKey(e => e.NewsTypeId).HasName("PRIMARY");

            entity.ToTable("news_types", tb => tb.HasComment("最新消息種類"));

            entity.Property(e => e.NewsTypeId)
                .HasComment("最新消息種類 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("news_type_id");
            entity.Property(e => e.CreatedAt)
                .HasComment("建立時間")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedUserId)
                .HasComment("建立帳號 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("created_user_id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasComment("最新消息種類名稱")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasComment("最後更新時間")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedUserId)
                .HasComment("最後更新帳號 PK")
                .HasColumnType("bigint(11)")
                .HasColumnName("updated_user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
