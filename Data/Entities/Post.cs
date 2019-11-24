using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Descption { get; set; }
        public int Likes { get; set; }
        public Blog Blog { get; set; }
    }
}