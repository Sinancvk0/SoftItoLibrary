using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class City:BaseModel
    {
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public List <District> Districts { get; set; }
  
    }
}
