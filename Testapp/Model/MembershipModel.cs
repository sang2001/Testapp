using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testapp.Model
{
    public class MembershipModel
    {
        public string MembershipName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean Status { get; set; }

    }
}
