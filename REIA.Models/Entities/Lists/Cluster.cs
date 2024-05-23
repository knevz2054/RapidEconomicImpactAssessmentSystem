using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class Cluster : DomainObject
    {
        [Required]
        public string ClusterName { get; set; }
    }
}
