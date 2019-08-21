using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
   public class City
    {
        public int Id { get; set; }
        [
            MaxLength(50),
            Required
         ]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection <District> Districts { get; set; }

    }
}
