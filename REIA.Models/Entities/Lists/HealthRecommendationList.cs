using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities.Lists
{
    public class HealthRecommendationList : DomainObject
    {
        [Required]
        public string ListHealthRecommendation { get; set; }
    }
}
