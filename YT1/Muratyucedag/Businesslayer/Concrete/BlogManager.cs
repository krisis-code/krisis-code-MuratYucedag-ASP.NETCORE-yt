﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogManager
    {
        [Key]
        public int BlogId { get; set; }
        public int MyProperty { get; set; }
        public string BlogTitle { get; set; }
        public String BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public CategoryManager Category { get; set; }
        public List<CommentManager> Comments { get; set; }
    }
}
