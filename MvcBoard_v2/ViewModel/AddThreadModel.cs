using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcBoard_v2.Models;

namespace MvcBoard_v2.ViewModel
{
    public class AddThreadModel
    {
        public int BoardId { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
