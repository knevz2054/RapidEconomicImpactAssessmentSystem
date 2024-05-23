using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class RespondentHealthCrisis : DomainObject
    {
        [Required]
        public string HealthCrisis { get; set; }
        [Required]
        public string Recommendation { get; set; }
        [ForeignKey("Respondent")]
        public int RespondentID { get; set; }
        public virtual Respondent Respondent { get; set; }
    }
}
