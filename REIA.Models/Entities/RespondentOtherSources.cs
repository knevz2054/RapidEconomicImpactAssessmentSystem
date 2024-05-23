using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class RespondentOtherSources : DomainObject
    {
        public string RespOtherSources { get; set; }
        [ForeignKey("Respondent")]
        public int RespondentID { get; set; }
        public virtual Respondent Respondent { get; set; }
    }
}
