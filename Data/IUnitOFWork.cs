using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOFWork
    {
        public IBlogRepository Blogs { get; }
        public IPostRepository Posts { get; }

        public Task Save();
    }
}