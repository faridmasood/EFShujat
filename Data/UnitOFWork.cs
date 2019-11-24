using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    internal class UnitOFWork : IUnitOFWork
    {
        private readonly BlogDBContext _dBContext;
        private readonly IServiceProvider _services;

        public UnitOFWork(BlogDBContext dBContext, IServiceProvider services)
        {
            _dBContext = dBContext;
            _services = services;
        }

        public IBlogRepository Blogs
        {
            get
            {
                return _services.GetService<IBlogRepository>();
            }
        }

        public IPostRepository Posts
        {
            get
            {
                return _services.GetService<IPostRepository>();
            }
        }

        public async Task Save()
        {
            await _dBContext.SaveChangesAsync();
        }
    }
}