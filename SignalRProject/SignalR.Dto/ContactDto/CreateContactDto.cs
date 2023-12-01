using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Dto.ContactDto
{
    public class CreateContactDto
    {
      

        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Location { get; set; }
        public string FooterDescr { get; set; }
    }
}
