using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class Clothing : DomainObject
    {
        [Required]
        public string Item { get; set; }
        [Required]
        public string Frequency { get; set; }
        [Required]
        public string Where { get; set; }
        [Required]
        public string Change { get; set; }
        [Required]
        public string Reason { get; set; }
        [ForeignKey("Respondent")]
        public int RespondentID { get; set; }
        public virtual Respondent Respondent { get; set; }
    }
}
