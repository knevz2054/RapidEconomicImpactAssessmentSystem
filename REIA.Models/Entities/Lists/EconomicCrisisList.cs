using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities.Lists
{
    public class EconomicCrisisList : DomainObject
    {
        [Required]
        public string ListEconomicCrisis { get; set; }
    }
}
