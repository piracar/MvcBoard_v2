using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBoard_v2.Models
{
   public class Thread
    {
        public int id { get; set; }
        public int BoardId { get; set; }
       // public Post OpPost { get; set; }
        public List<Post> Posts { get; set; }

    }
}
