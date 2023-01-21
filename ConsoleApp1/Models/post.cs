using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Post
    {

        public int PostId { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }


        // Relation With blog
        public int BlogId{ get; set; }
        public Blog Blog { get; set; }


    }
}
