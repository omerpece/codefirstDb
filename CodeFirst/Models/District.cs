using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace CodeFirst.Models
{
    public class District
    {
        public int Id { get; set; }
        [
            MaxLength(50),
            Required
         ]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }
        public int CityId { get; set; }
        public virtual  City City { get; set; }

    }
}
