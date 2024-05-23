using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class Survey : DomainObject
    {
        public DateTime DateSurveyed { get; set; }
        public string EnumeratorsCode { get; set; }
        public string RespondentCode { get; set; }
        [ForeignKey("Respondent")]
        public int RespondentID { get; set; }
        public virtual Respondent Respondent { get; set; }

    }
}
