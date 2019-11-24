using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    internal class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(BlogDBContext dBContext) : base(dBContext)
        {
        }
    }
}