using LSGames.News.Repository.DBContexts;
using LSGames.News.Repository.Models;
using LSGames.News.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGames.News.Repository.Repositories
{
    public class NewsTypeRepository : GenericRepository<NewsType>, INewsTypeRepository
    {
        private LsgamesNewsContext _context;
        public NewsTypeRepository(LsgamesNewsContext context) : base(context)
        {
            _context = context;
        }
    }
}
