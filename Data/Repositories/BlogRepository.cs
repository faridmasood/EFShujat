using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class BlogRepository : BaseRepository<Blog>, IBlogRepository

    {
        public BlogRepository(BlogDBContext dBContext) : base(dBContext)
        {
        }

        public async Task<List<Blog>> GetWithoutPosts(int blogId)
        {
            var data = await _dBContext.Blog.Where(b => !b.Posts.Any()).ToListAsync();
            return data;
        }
    }
}