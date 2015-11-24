using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcBoard_v2.Models;

namespace MvcBoard_v2.ViewModel
{
   public class ShowThreadsModel
    {
       public List<Thread> Threads { get; set; }
       public int BoardId { get; set; }
    }
}
