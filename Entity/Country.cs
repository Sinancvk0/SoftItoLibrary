using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Country:BaseModel
    {
        public List<City> Cities { get; set; }
     
    }
}
