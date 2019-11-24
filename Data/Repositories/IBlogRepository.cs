using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IBlogRepository : IBaseRepository<Blog>
    {
        Task<List<Blog>> GetWithoutPosts(int blogId);
    }
}