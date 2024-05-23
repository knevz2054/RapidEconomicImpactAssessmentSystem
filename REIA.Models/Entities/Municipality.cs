using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class Municipality : DomainObject
    {
        [Required]
        public string MunicipalityName { get; set; }
        [Required]
        public string District { get; set; }
        public virtual ICollection<Barangay> Barangays { get; set; }
    }
}
