using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Dto.MonialDto
{
    public class ResultMonialDto
    {
        public int monialID { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}

