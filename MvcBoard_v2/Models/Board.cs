using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBoard_v2.Models
{
    public class Board
    {
        public int id { get; set; }
        public string Name  { get; set; }
        public List<Thread> Threads { get; set; } 
        }
}
