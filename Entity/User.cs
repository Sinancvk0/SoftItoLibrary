using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User : BaseModel
    {
        public string NationalId { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public int AdrressId { get; set; }

        public Adrress Adrress { get; set; }
  

        public Hire Hire { get; set; }


    }
}
