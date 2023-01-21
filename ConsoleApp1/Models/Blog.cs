using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Blog
    {

        public int BlogId { get; set; }
        public string Url { get; set; }

        public DateTime createDate{ get; set; }

        // Relation one to many
        public List<Post> Posts { get; } = new List<Post>();
    }
}
