using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFieldManagement.Domain.Models
{
    public class Area : DomainObject
    {
        public string AreaName { get; set; }
        public string AreaNote { get; set; }
    }
}
