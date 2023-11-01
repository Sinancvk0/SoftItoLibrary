using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Adrress:BaseModel
    {
        public int DistrictId { get; set; }

        public District District { get; set; }

        public List<User> Users { get; set; }
    }
}
