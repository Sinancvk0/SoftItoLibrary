using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public  class District:BaseModel 
    {
        public int CityId { get; set; }
        public City City { get; set; }
        public List<Adrress> Adrresses { get; set; }





    }
}
