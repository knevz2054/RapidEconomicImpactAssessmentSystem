using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class Barangay : DomainObject
    {
        [Required]
        public string BarangayName { get; set; }
        public string BarangayCluster { get; set; }
        [ForeignKey("Municipality")]
        public int MunID { get; set; }
        public virtual Municipality Municipality { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
