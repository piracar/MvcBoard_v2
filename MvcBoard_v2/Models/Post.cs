using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBoard_v2.Models
{
    public class Post
    {
        public int id { get; set; }
        public int ThreadId { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
        public string Ip { get; set; }
    }
}
