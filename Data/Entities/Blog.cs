using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public List<Post> Posts { get; set; }
    }
}