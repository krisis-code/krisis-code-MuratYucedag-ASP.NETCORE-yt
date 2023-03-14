using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class CategoryManager
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public String CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public List<BlogManager> Blogs { get; set; }
    }
}
